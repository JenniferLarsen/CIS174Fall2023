"""
Program: average_scores.py
Author: Jennifer Larsen
Last date modified: 09/06/2023
The purpose of this program is to take user input and calculate
the average of 4 test scores.
The input is an integer representing the user's name, age, four integers representing
the four test scores.
The output is a summary of the input with the average test score
"""

#Ask user their name, age and test scores
NUM_OF_TEST_SCORES = 4
first_name = input("Please enter your First name:")
last_name = input("Please enter your Last name:")
user_age = int(input("Please enter your age:"))
first_test = int(input("Please enter the first test score:"))
second_test = int(input("Please enter the second test score:"))
third_test = int(input("Please enter the third test score:"))
fourth_test = int(input("Please enter the fourth test score:"))

average_score = (first_test + second_test + third_test + fourth_test)/NUM_OF_TEST_SCORES

print(f"{last_name}, {first_name}  Age: {user_age}. Your average test score is {average_score:.2f}.")

"""  Manual Testing Completed:
1. 
Please enter your First name:Jennifer
Please enter your Last name:Larsen
Please enter your age:42
Please enter the first test score:99
Please enter the second test score:89
Please enter the third test score:92
Please enter the fourth test score:98
Larsen, Jennifer  Age: 42. Your average test score is 94.50.

2. 
Please enter your First name:Jennifer
Please enter your Last name:Larsen
Please enter your age:42
Please enter the first test score:80
Please enter the second test score:70
Please enter the third test score:90
Please enter the fourth test score:60
Larsen, Jennifer  Age: 42. Your average test score is 75.00.

3.
Please enter your First name:Douglas
Please enter your Last name:Larsen
Please enter your age:45
Please enter the first test score:40
Please enter the second test score:50
Please enter the third test score:22
Please enter the fourth test score:99
Larsen, Douglas  Age: 45. Your average test score is 52.75.
"""

