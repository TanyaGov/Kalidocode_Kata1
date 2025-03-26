# Kalidocode String Kata 1

Requirements
Create a simple String calculator with a method int Add(string numbers)
The method can take 0, 1 or 2 numbers, and will return their sum (for an empty string it will return 0), for example, “” or “1” or “1,2”
Start with the simplest test case of an empty string and move to 1 and two numbers
Remember to solve things as simply as possible so that you force yourself to write tests you did not think about
Remember to refactor after each passing test
Allow the Add method to handle an unknown amount of numbers
Allow the Add method to handle new lines between numbers (instead of commas)
the following input is ok: “1\n2,3”  (will equal 6)
the following input is NOT ok: “1,\n” (no need to prove it - just clarifying)
Support custom delimiters
to change a delimiter, the beginning of the string will contain a separate line that looks like this:   “//[delimiter]\n[numbers…]” for example “//;\n1;2” should return 3 where the default 
delimiter is ‘;’
the first line is optional - all existing scenarios should still be supported (i.e. default delimiters )
Calling Add with a negative number will throw an exception with the message “Negatives not allowed: {negative numbers}” where “{negetive numbers}” is the negative numbers that were found in the string. If more than one negative is found in the input, show them all in the exception message.
Numbers bigger than 1000 should be ignored, so adding 2 + 1001  = 2
Support custom delimiters of any length with the following format:  “//[delimiter]\n” for example: “//***\n1***2***3” should return 6.
Allow multiple custom delimiters like this:  “//[delim1][delim2]\n” for example “//[*][%]\n1*2%3” should return 6. Note that the square brackets seen here are only required for multiple custom delimiters. A single custom delimiter (requirement 7) does not need the square brackets.
Make sure you can also handle multiple custom delimiters with lengths longer than one character
