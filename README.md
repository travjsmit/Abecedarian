#1 Exercise 7.10. A word is said to be "abecedarian" if the letters in the word appear in alphabetical order. For example, 
the following are all 6-letter English abecedarian words: abdest, agnosy, biopsy, deux, dimpsy
  1. Describe a process for checking whether a given word (string) is abecedarian, assuming that the word contains only lower-case letters. 
     Your process can be iterative or recursive.

  Iterative Process:
  Start from the first character of the string.
  Compare each character to the next character in the string.
  If any character is greater than the next character, return false.
  If you reach the end of the string without finding any characters out of order, return true.
  
  2. Implement your process in a method called IsAbecedarian.

     See code.
