Feature: Check if a number is a prime number
  As a user
  I want to check if a number is prime
  So that I can verify the primality of a given number

  Scenario Outline: Check if a number is prime
    Given the prime number is <number>
    When I check if the number is prime
    Then the prime result should be "<isPrime>"

    Examples:
      | number | isPrime |
      | 2      | Prime   |
      | 3      | Prime   |
      | 5      | Prime   |
      | 7      | Prime   |
      | 11     | Prime   |
      | 13     | Prime   |
      | 17     | Prime   |
      | 19     | Prime   |
      | 23     | Prime   |
      | 29     | Prime   |
      | 31     | Prime   |
      | 37     | Prime   |
      | 41     | Prime   |
      | 43     | Prime   |
      | 47     | Prime   |
      | 53     | Prime   |
      | 59     | Prime   |
      | 61     | Prime   |
      | 67     | Prime   |
      | 71     | Prime   |

  Scenario Outline: Check if a number is not prime
    Given the prime number is <number>
    When I check if the number is prime
    Then the prime result should be "Not Prime"

    Examples:
      | number |
      | 8      |
      | 9      |
      | 10     |
      | 12     |
      | 14     |
      | 15     |
      | 16     |
      | 18     |
      | 20     |
      | 21     |
      | 22     |
      | 24     |
      | 25     |
      | 26     |
      | 27     |
      | 28     |
      | 30     |
      | 32     |
      | 33     |
      | 34     |

