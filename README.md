# prosource-matching-brackets
This is a technical assessment for JobNimbus

Write a method that takes a string argument and returns whether or not characters in the string
have matching brackets. Meaning for every { there is a corresponding } bracket. Return true if
they do, return false if they do not.
Please unit test with the following use cases (and any others you choose to ensure functionality)
- also, please be sure to show your unit tests:

Test string - Expected result
- {} - True
- }{ - False (closed bracket can't proceed all open brackets.)
- {{} - False (one bracket pair was not closed)
- "" - True. (no brackets in the string will return True)
- {abc...xyz} - True (non-bracket characters are ignored appropriately)

Created a solution composed of:
- the main project to execute the program
- the business project to handle the requirements/logic
- the test project to test different scenarios

Here is a screenshot of the Tests scenarios that passed:
> <img width="396" alt="UnitTestScreenshots" src="https://user-images.githubusercontent.com/128790167/227481353-15f9882a-871a-4755-978e-0c57c73202c4.PNG">


After cloning the repository please do a rebuild/build and run the application. 
You may also run the test afterwards.
