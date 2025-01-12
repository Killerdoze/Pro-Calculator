Feature: Division
    Simple calculator for dividing two numbers.

    Scenario: Divide two numbers
        Given the first number for division is 10.0
        And the second number for division is 2.0
        When the two numbers are divided
        Then the result for division should be 5.0

    Scenario: Division by zero
        Given the first number for division is 10.0
        And the second number for division is 0.0
        When the two numbers are divided
        Then the result for division should be NaN
