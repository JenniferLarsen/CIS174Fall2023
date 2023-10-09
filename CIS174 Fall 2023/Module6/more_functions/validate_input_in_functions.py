"""
validate input in functions
Jennifer Larsen
10/9/2023
This module contains functions and validates input
"""


def score_input(test_name, test_score=-1, invalid_message='Invalid test score!'):
    try:
        test_score = int(test_score)
        if 0 <= test_score <= 100:
            return f'{test_name}: {test_score}'
        else:
            return f'{test_name}: {invalid_message}'
    except ValueError:
        return f'{test_name}: ValueError encountered!'


if __name__ == "__main__":
    # Good input
    display_string = score_input('Test 1', 70)
    print(display_string)

    # Value below the range
    display_string = score_input('Test 2', -5)
    print(display_string)

    # Value above the range
    display_string = score_input('Test 3', 105)
    print(display_string)

    # Non-numeric input
    # noinspection PyTypeChecker
    display_string = score_input('Test 4', 'abc')
    print(display_string)
