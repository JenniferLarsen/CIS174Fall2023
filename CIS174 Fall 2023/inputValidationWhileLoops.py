"""
Input Validation While Loops
Jennifer Larsen
9/28/2023
This module contains while loops and input validation.
"""

userList = []
sent_value = "continue"

while sent_value != "quit":
    user_input = input("Please enter an integer between 1 and 100 or type 'quit' to exit: ")
    if user_input.isdigit():
        userNum = int(user_input)
        if 1 <= userNum <= 100:
            userList.append(userNum)
        else:
            print(userNum, "is not a valid integer. Please enter an integer between 1 and 100.")
    elif user_input.lower() == "quit":
        sent_value = "quit"
    else:
        print("Invalid input. Please enter a valid integer 1 - 100, or type 'quit' to exit.")

print("List of entered numbers:")
for number in userList:
    print(number)

"""
Test cases entered and results:

Please enter an integer between 1 and 100 or type 'quit' to exit: -1
Invalid input. Please enter a valid integer 1 - 100, or type 'quit' to exit.
Please enter an integer between 1 and 100 or type 'quit' to exit: 122
122 is not a valid integer. Please enter an integer between 1 and 100.
Please enter an integer between 1 and 100 or type 'quit' to exit: 101
101 is not a valid integer. Please enter an integer between 1 and 100.
Please enter an integer between 1 and 100 or type 'quit' to exit: 0
0 is not a valid integer. Please enter an integer between 1 and 100.
Please enter an integer between 1 and 100 or type 'quit' to exit: 22
Please enter an integer between 1 and 100 or type 'quit' to exit: 33
Please enter an integer between 1 and 100 or type 'quit' to exit: 44
Please enter an integer between 1 and 100 or type 'quit' to exit: 55
Please enter an integer between 1 and 100 or type 'quit' to exit: 66
Please enter an integer between 1 and 100 or type 'quit' to exit: quit
List of entered numbers:
22
33
44
55
66

Process finished with exit code 0

"""