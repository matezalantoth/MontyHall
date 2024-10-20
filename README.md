# Monty Hall
The Monty Hall Problem, the greatest example of mankind's befuddlement with probability and statistics. 
It posits that you have the choice of three doors, one contains a prize while the other two contain
assorted junk. This simple algorithm provides a proof for any doubters who wish to see it work for themselves.

## How To Run
It should be good to go out of the box.
In case of a build error, run nuget restore in the solution file entitled: MontyHallProof

## Why Does It Work
The Monty Hall Problem states that choosing a door, will give you a 33.3% to win, whereas switching after a
door is eliminated will give you a 66.7% chance to win, this doesn't make that much sense to our brains as
we would assume that it would be a 50/50 chance after a door is eliminated because you either picked the correct
door or you didn't there is a 50% chance that you were right or wrong, right? No, because of important rules
that outlined regarding this game. Monty must always eliminate a door that doesn't contain the prize. We focus
too much on the probability of the player and not the implication of Monty's actions. Our door retains its 33%
chance of being correct because no information has changed regarding it. However the other door's probabilities
have changed dramatically, because Monty has eliminated a wrong door. Meaning 33% of the time that we picked correctly
Monty's choice was utterly random and the door has therefore got a 33% chance of also being wrong. However since 66.7%
of the time Monty didn't eliminate a door based on chance and had to choose to eliminate the door that didn't 
have the prize. Meaning that the remaining door has now got a 66.7% chance of being the door with the prize because
66.7% of the time we picked incorrectly.
