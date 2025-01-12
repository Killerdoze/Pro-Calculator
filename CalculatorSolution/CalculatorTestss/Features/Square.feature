Feature: Calculate Square Root of a Number
  As a user
  I want to calculate the square root of a given number
  So that I can verify the correct result

  Scenario: Calculate the square root of a positive number
    Given I have entered the number 16.0
    When I calculate the square root
    Then the square result should be 4.0

  Scenario: Calculate the square root of zero
    Given I have entered the number 0.0
    When I calculate the square root
    Then the square result should be 0.0

  Scenario: Calculate the square root of a negative number
    Given I have entered the number -9.0
    When I calculate the square root
    Then I should receive an error message
