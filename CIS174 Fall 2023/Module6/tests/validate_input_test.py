import unittest
from more_functions.validate_input_in_functions import score_input
# from directory.filename import function NOTE: yours might be named something else


class MyTestCase(unittest.TestCase):

    def test_valid_score(self):
        # Arrange
        expected = 'GoodTest: 70'
        # Act
        actual = score_input('GoodTest', 70)
        # Assert
        self.assertEqual(expected, actual)

    def test_below_range_score(self):
        # Arrange
        expected = 'BadTest: Invalid test score!'
        # Act
        actual = score_input('BadTest', -10)
        # Assert
        self.assertEqual(expected, actual)

    def test_above_range_score(self):
        # Arrange
        expected = 'BadTest: Invalid test score!'
        # Act
        actual = score_input('BadTest', 107)
        # Assert
        self.assertEqual(expected, actual)

    def test_exception_thrown(self):
        # Arrange
        # Act
        # Assert
        with self.assertRaises(ValueError):
            score_input('BadTest', 'car')


if __name__ == '__main__':
    unittest.main()
