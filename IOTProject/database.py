from typing import List, Tuple, Union
import sqlite3
from sqlite3 import Error, Connection, Cursor
import logging
from dataclasses import dataclass

L = logging.getLogger()


@dataclass
class UserPrefs:
    user_id: int
    user_name: str
    user_email: str
    user_image: str
    temp_threshold: float
    light_intensity: int


class UserPrefsDB:
    def __init__(self, db_file: str) -> None:
        self._conn = self.create_connection(db_file)

    def create_connection(self, db_file: str) -> Union[Connection, None]:
        conn = None
        try:
            conn = sqlite3.connect(db_file)
            return conn
        except Error as e:
            L.fatal(e)

    def commit(self) -> bool:
        if self._conn:
            self._conn.commit()
            return True

        return False

    def close(self) -> bool:
        if self._conn:
            self._conn.close()
            return True

        return False

    def query(self, query: str, params: Tuple = ()) -> Union[Cursor, None]:
        cur = None
        if self._conn:
            cur = self._conn.cursor()
            cur.execute(query, params)
        else:
            L.warn("Database connection not established.")

        return cur

    def execute(self, query: str, params: Tuple = ()) -> bool:
        cur = self.query(query, params)
        if cur:
            self._conn.commit()
            return True
        else:
            L.warn("Database cursor not established")

        return False

    def fetch_all(self, query: str, params: Tuple = ()) -> List[UserPrefs]:
        cur = self.query(query, params)
        rows = []
        if cur:
            rows = cur.fetchall()
        return [
            UserPrefs(id, name, email, image, temp, light)
            for (id, name, email, image, temp, light) in rows
        ]

    def fetch_single(self, query: str, params: Tuple = ()) -> Union[UserPrefs, None]:
        rows = self.fetch_all(query, params)
        return rows[0] if rows else None


if __name__ == "__main__":
    db = UserPrefsDB(r"./iot.db")
    db.execute(
        """
        CREATE TABLE IF NOT EXISTS user_prefs (
            user_id TEXT PRIMARY KEY,
            user_name TEXT NOT NULL,
            user_email TEXT NOT NULL,
            user_image TEXT NOT NULL,
            temp_threshold REAL DEFAULT 20.0 NOT NULL,
            light_intensity INTEGER DEFAULT 80 NOT NULL
        );
        """
    )
    db.execute(
        """
        INSERT INTO user_prefs
            (user_id, user_name, user_email, user_image, temp_threshold, light_intensity)
        VALUES
            (?, ?, ?, ?, ?, ?);
        """,
        ("A3168F11", "Armen", "2086139@iotvanier.com", "https://www.bsn.eu/wp-content/uploads/2016/12/user-icon-image-placeholder.jpg", 19.0, 100),
    )
    db.execute(
        """
        INSERT INTO user_prefs
            (user_id, user_name, user_email, user_image, temp_threshold, light_intensity)
        VALUES
            (?, ?, ?, ?, ?, ?);
        """,
        ("C31B8B", "Alvin", "1960943@iotvanier.com", "http://www.newdesignfile.com/postpic/2014/07/generic-user-icon-windows_352871.png", 25.0, 130),
    )
    print(db.fetch_all("SELECT * FROM user_prefs"))
