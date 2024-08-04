# Infineon_Exercises

### Explanation to what is contained here.
*  This project contains the first and third Exercises
#### Exercise One
##### Explanations:
*  It's easy to create just a forloop to generate any random number 100 times but the class & method
  ```int x = new Random.Next(1, 101)``` generates randomly and may generate a number multiple times, and this will cause the output to not have numbers 1 - 100.
*  Just for verification that all numbers were generated and there are no duplicate, I created a test method to verify if there are multiple numbers.
  
I created an integer array named checker with the length of 100 to hold all the values generated.
Then the forloop iterates from 1 - 100, and each time it iterates, ```Random.Next()``` generates a random number which is first checked with an if statement to see if the number already exists in checker[], and if it does exist, 
we will reduce the value of i (iteration) by 1 i.e ```i--;``` which will help us sustain the count from 1-100. Example: lets assume the first iteration has the random number = 2 which is stored in checker[]. Unfortunately, the second iteration also produced a random number = 2 which ```checker.Contains()``` will detect and skip because I didn't add it to any index of checker. If we continue without reducing the iteration, it will mean that we already done two correct moves which is false because one of the iterations is invalid because of duplication.
