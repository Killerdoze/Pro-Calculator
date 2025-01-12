Feature: Subtraction Operation
  A simple calculator to subtract two numbers

  Scenario: Subtract two numbers
    Given the first number for subtraction is 20.0
    And the second number for subtraction is 10.0
    When the two numbers are subtracted
    Then the result for subtraction should be 10.0
