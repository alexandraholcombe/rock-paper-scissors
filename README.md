# Rock, Paper, Scissors

#### _A web application to play Rock, Paper, Scissors with two players_

#### By _**Alexandra Holcombe && Shruti Priya**_

## Description

This web application will recreate the game Rock, Paper, Scissors with two players.
* Each player chooses "rock," "paper," or "scissors."
* They choose at the same time so that each person doesn't know what the other person has chosen.
* If one person chooses "Rock" and the other person chooses "Scissors," then Rock wins.
> * Rock v. Scissors = Rock wins
> * Rock v. Paper = Paper wins
> * Paper v. Scissors = Scissors wins
* If both people choose the same thing, then it is a draw and nobody wins.

## Setup/Installation Requirements

* Requires DNU, DNX, and Mono
* Clone to local machine
* Use command "dnu restore" in command prompt/shell
* Use command "dnx kestrel" to start server
* Navigate to http://localhost:5004 in web browser of choice

## Specifications

**If both players choose the same thing, the game returns a "Draw."**
* Example Player1: "Rock" and  Player2 : "Rock"
* Example Output: "It's a tie."

**If player 1 chooses "rock" and player 2 chooses "scissors," then player 1 wins.**
* Example Input: Player 1: "Rock" Player 2: "Scissors"
* Example Output: "Player 1 Wins!"

**If player 1 chooses "rock" and player 2 chooses "paper," then player 2 wins.**
* Example Input: Player 1: "Rock" Player 2: "Paper"
* Example Output: "Player 2 Wins!"

**If player 1 chooses "scissors" and player 2 chooses "rock," then player 2 wins.**
* Example Input: Player 1: "Scissors" Player 2: "Paper"
* Example Output: "Player 2 Wins!"

**If player 1 chooses "scissors" and player 2 chooses "paper," then player 1 wins.**
* Example Input: Player 1: "scissors" Player 2: "paper"
* Example Output: "Player 1 wins!"

**If player 1 chooses "paper" and player 2 chooses "rock," then player 1 wins.**
* Example Input: Player 1: "paper" Player 2: "rock"
* Example Output: "Player 1 Wins!"

**If player 1 chooses "paper" and player 2 chooses "scissors," then player 2 wins.**
* Example Input: Player 1: "paper" Player 2: "scissors"
* Example Output: "Player 2 Wins!"

## Support and contact details

Please contact Allie Holcombe at alexandra.holcombe@gmail.com or Katy Daviscourt at katy.daviscourt@gmail.com with any questions, concerns, or suggestions.

## Technologies Used

This web application uses:
* Nancy
* Mono
* DNVM
* C#
* Razor

### License

*This project is licensed under the MIT license.*

Copyright (c) 2017 **_Alexandra Holcombe & Shruti Priya_**
