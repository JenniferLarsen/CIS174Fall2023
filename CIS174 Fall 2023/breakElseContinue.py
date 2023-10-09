"""
This program prompts the user to enter numbers between 1 and 100 until they want to exit.
"""

userList = []

while True:
    sent_value = input('Type "quit" to exit or "c" to continue: ')

    if sent_value.lower() == "quit":
        break

    if sent_value.lower() != "c":
        print("Invalid input. Please type 'quit' to exit or 'c' to continue.")
        continue

    user_input = input("Please enter a number between 1 and 100: ")

    if user_input.isdigit():
        userNum = int(user_input)
        if 1 <= userNum <= 100:
            userList.append(userNum)
        else:
            print(userNum, "is not a valid number. Please enter a number between 1 and 100.")
    else:
        print("Invalid input. Please enter a valid number.")

# Display the list of entered numbers
print("List of entered numbers:")
for number in userList:
    print(number)

"""
Manual testing and outputs:
Type "quit" to exit or "c" to continue: c
Please enter a number between 1 and 100: -1
Invalid input. Please enter a valid number.
Type "quit" to exit or "c" to continue: 101
Invalid input. Please type 'quit' to exit or 'c' to continue.
Type "quit" to exit or "c" to continue: 22
Invalid input. Please type 'quit' to exit or 'c' to continue.
Type "quit" to exit or "c" to continue: c
Please enter a number between 1 and 100: 22
Type "quit" to exit or "c" to continue: 33
Invalid input. Please type 'quit' to exit or 'c' to continue.
Type "quit" to exit or "c" to continue: c
Please enter a number between 1 and 100: 33
Type "quit" to exit or "c" to continue: c
Please enter a number between 1 and 100: 44
Type "quit" to exit or "c" to continue: quit
List of entered numbers:
22
33
44

Process finished with exit code 0
"""