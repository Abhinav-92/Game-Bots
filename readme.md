# Game-Bots
Zynga Hackathon

Metor Rush


How they Have designed the game?

Concept: Meteor Crush is an endless arcade-style 2D game where the player controls a
spaceship that must survive an onslaught of falling meteors. The player must dodge the
meteors and destroy them to score points and progress to higher levels

Gameplay: The game takes place on a 2D plane, with the spaceship controlled by the player
swiping left and right at the bottom of the screen.d the player must avoid them by moving out of the way (horizontally by
swiping) or shooting them down with the spaceship's lasers.The game is endless, and the
challenge for the player is to score as high as possible. The player will have 3 lives in their
bank, and being hit by a meteor reduces a life. Losing all 3 lives ends the session and records
their score. 




Architecture and art - 
 The architecture mainly consist of 2 modules namely  - Scoring System,Player Abilities and Controls


Scoring system: The player will earn points for both dodging meteors and destroying them.
● Dodging will give the player 5 points per meteor.
● Destroying a small or medium sized meteor will give the player 10 points.
● Larger meteors which are difficult to destroy will give the player 20 points each.
● Destroying should carry a higher weightage to encourage players to take higher risks
for higher rewards.
● Smaller & medium meteors will be destroyed in 1 Hit, Larger meteors will take 3 hits to
destroy. Larger meteors will have 3 distinct visual states to show that it is damaged,
and close to getting destroyed. 

Player abilities:
● Multi-laser shot
● Spread damage
● Forcefield

Controls: To move the spaceship, the player can swipe left or right. The spaceship can be
moved horizontally on screen, but not vertically. To shoot, the player needs to tap on the Shoot
button. 


Art style: The game will have a retro-style 2D art style, with pixelated graphics and bright,
neon colors. The spaceship and meteors will be easily distinguishable from each other, and the
background will be a starry space scene.

The Art was Created By- Sashreek Mishra



No,There is no scope of upgrading into multiplayer version. Since,it is a retro style arcade
 game so all the fun playing this game lies in playing this game alone and trying to beat you own Highscore.