# NumberGuesser

"I'm thinking of a number between 1 and ..."

Objectives 
- Demonstrate usage of methods to organize code. 
- Understand and implement algorithms.
- Understand loops.

Requirements
- Your program should be able to handle a person thinking of a number between *1* and *1024*. 
- Your program should assume the human player would answer any guess truthfully.

Explorer Mode
- Once the program starts, you should display a *greeting* to the user describer the challenge. 
- *Prompt* the user with your guess and allow them to tell you if their number is *higher*, *lower*, or *correct*. 
- Keep refining your guess until you have the correct answer. 
- Use methods to organize your code. Here are some suggestions for methods you might use:
  + ShowGreeting
  + ComputeNewLowIfTooLow
  + ComputeNewHightIfTooHigh
  + BragWhenCorrect
- Use at least one or two methods

Adventure Mode
- Allow the user to choose the maximum number for their range. 
- Tell them the most number of guesses your code will need! Log 2
- Prompt the user to play again at the end of the game. 

Epic Mode
- Keep track of how many guesses each game has taken and show the average number of guesses your code used. 
  For instance, if you've played three games and took 4, 6, and 2, guesses, your average would be 4.


  PEDAC

  P - computer must guess what number the user is thinking of between 1 and 1024

  E - use while , if and else if statements to validate user response

  D - low number, high number, guess, userResponse, ShowGreeting, BragWhenCorrect, if statements, bool to validate, do while to prompt player to play again

  A - 
    display greeting
    prompt user to guess number between 1 and 1024 and not tell us
    guess number
    based on user input of higher, lower, or correct 
      compute 
        if lower high = guess
          after user input of lower - next guess should equal (low + high) / 2 
            repeat until correct
        if higher low = guess
         after user input of higher - next guess should equal (low + high) / 2 
            repeat until correct
        if correct go to BragWhenCorrect
        if invalid option given end game
    

  C - see Program.cs

S A M P L E  O U T P U T

Greetings. I am the amazing Number Guesser.

Please think of, BUT DO NOT TELL ME, a number between 1 and 1024.

Using my amazing computing power I will figure out your number by asking you questions.

Here we go!

My guess is 1. Is your number HIGHER, LOWER, or am I CORRECT? HIGHER

Ok, higher.

My guess is 2. Is your number HIGHER, LOWER, or am I CORRECT? HIGHER

Ok, higher.

My guess is 3. Is your number HIGHER, LOWER, or am I CORRECT? CORRECT
