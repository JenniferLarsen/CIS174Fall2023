"""
inner functions assignment
Jennifer Larsen
10/9/2023
This module contains nested functions to calculate and return the area
and perimeter of a rectangle.
"""


def measurements(a_list):
    def area(a_list):
        if len(a_list) == 2:
            answer = a_list[0] * a_list[1]
        elif len(a_list) == 1:
            answer = a_list[0] ** 2
        else:
            return 0
        return answer

    def perimeter(a_list):
        if len(a_list) == 2:
            answer = (a_list[0] * 2) + (a_list[1] * 2)
        elif len(a_list) == 1:
            answer = a_list[0] * 4
        else:
            return 0
        return answer

    p = perimeter(a_list)
    a = area(a_list)

    return f'Perimeter = {p:.2f} Area = {a:.2f}'


if __name__ == '__main__':
    rectangle = [2.1, 3.4]
    result = measurements(rectangle)
    print(result)
    square = [3.5]
    result = measurements(square)
    print(result)
