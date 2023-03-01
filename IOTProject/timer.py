from time import time_ns


class Timer:
    def __init__(self):
        self.start = time_ns()

    def is_second_elapsed(self, end: int) -> bool:
        """Checks if given end time in seconds has elapsed from the start time

        Args:
            end (int): The amount of time elapsed to be checked

        Returns:
            bool: TRUE if current - start > end else FALSE
        """
        end_in_ns = end * 1_000_000_000
        return time_ns() - self.start > end_in_ns

    def reset_start_to_current(self):
        self.start = time_ns()
