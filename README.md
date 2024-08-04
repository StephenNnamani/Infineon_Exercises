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
The else simply adds the non-duplicated random number to checker in the index of ```i-1``` because our iteration started from 1 but the index of every array starts from 0.
```if (x % 7 == 0) Console.WriteLine("Lucky number!");``` Just checks if the random number generated is divisible by 7 without remainder, then it outputs "Lucker number!"
```if (i % 5 == 0) Console.WriteLine("---");``` checks if it has made up to 5 iterations by using the modulo operator to confirm if the number of iterations is divisible by 5 without remainder.

``` TestClass.TestMethod(checker); ``` is just the class/method that I wrote to verify the exercise by passing in the checker[] which contains all the valid random numbers. It loops through the array to see if the numbers 1 - 100 are contained in the checker[]. 

Just for the fun: I added a small animation with ```Thread.sleep(600);``` to print "-" (loading effect) and ```Console.ForegroundColor = ConsoleColor.color;``` to change the colors to RED when there's a duplicated number and GREEN when there's none

#### Exercise Three
This is simply to demonstrate my response on the pdf submited. 


## Additional Link
The GitHub link to the referenced repo where the design patterns were used
https://github.com/StephenNnamani/CompanyEmployees.git
