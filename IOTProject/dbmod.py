from sys import argv, exit

from database import UserPrefsDB

db = UserPrefsDB('./iot.db')

def create_user():
    print("User creation selected")
    user_id = input("Enter user rfid: ")
    name = input("Enter user name: ").strip()
    email = input("Enter user email: ").strip()
    image = input("Enter image url: ").strip()
    temp_threshold = input("Enter temperature threshold: ").strip()
    light_intensity = input("Enter light intensity: ").strip()
    db.execute(
        """
        INSERT INTO user_prefs
            (user_id, user_name, user_email, user_image, temp_threshold, light_intensity)
        VALUES
            (?, ?, ?, ?, ?, ?);
        """,
        (user_id, name, email, image, temp_threshold, light_intensity)
    )
    print()
    print(f"User {user_id} inserted")
    print_user(db.fetch_single("SELECT * FROM user_prefs WHERE user_id = ?", (user_id,)))

def read_users():
    print("User read selected")
    users = db.fetch_all('SELECT * FROM user_prefs')
    mx = 0
    for u in users:
        id_prompt = f"ID: {u.user_id}"
        name_prompt = f"Name: {u.user_name}"
        email_prompt = f"Email: {u.user_email}"
        image_prompt = f"Image: {u.user_image}"
        temp_prompt = f"Temp Threshold: {u.temp_threshold}"
        light_prompt = f"Light Intensity: {u.light_intensity}"
        mx = max(mx, max(len(id_prompt), len(name_prompt), len(email_prompt), len(image_prompt), len(temp_prompt), len(light_prompt)))

    for u in users:
        print("-" * mx)
        print_user(u)
    print("-" * mx)

def delete_user():
    print("User delete selected")
    user_id = input("Enter user_id: ")
    db.execute("DELETE FROM user_prefs WHERE user_id = ?", (user_id,))
    print(f"User {user_id} deleted")

def print_user(u):
        id_prompt = f"ID: {u.user_id}"
        name_prompt = f"Name: {u.user_name}"
        email_prompt = f"Email: {u.user_email}"
        image_prompt = f"Image: {u.user_image}"
        temp_prompt = f"Temp Threshold: {u.temp_threshold}"
        light_prompt = f"Light Intensity: {u.light_intensity}"
        print(id_prompt)
        print(name_prompt)
        print(email_prompt)
        print(image_prompt)
        print(temp_prompt)
        print(light_prompt)


if __name__ == '__main__':
    if len(argv) != 2:
        print("Usage: Enter the command you want")
        print("Commands: create, read, delete")
        exit(-1)

    if argv[1].lower() == 'create':
        create_user()
    elif argv[1].lower() == 'read':
        read_users()
    elif argv[1].lower() == 'delete':
        delete_user()
    else:
        print("Commands: create, read, delete")