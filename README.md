# Infineon_Exercises

### Explanation to what is contained here.
*  This project contains the first and third Exercises
#### Exercise One
##### Explanations:
*  It's easy to create just a forloop to generate any random number 100 times but the class & method
  ```int x = new Random.Next(1, 101)``` generates randomly and may generate a number multiple times, and this will cause the output to not have numbers 1 - 100.
*  Just for verification that all numbers were generated and there are no duplicate, I created a test method to verify if there are multiple numbers.
  
I created an integer array named checker with the length of 100 to hold all the values
