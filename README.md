# Hand of Cards Game Mechanic
By Ilya Vaschillo
Date: 4/8/25
https://manyak404.github.io/HandOfCards/

**Controls: 
SPACE to draw from deck.  
Left Click on card to pick up.  
Left Click again to place in hand or on table.**

## Hand Spread
- Central origin far below camera center to create a circumference of cards. This circle must be big because only a small arc (60 degrees) will be used to display cards on it. To have a bigger arc distance for the cards to spread on the radius must be large. Follow formula arc length=  π/3 r in the case of 60 degrees.
- Each cards position is dependent on 〖x= r〗⁡cos(θ)  and  〖y= r〗⁡sin(θ) 
- Rotation is dependent on an angle iterating by card count through 60 degrees (except in low card count where spread arc is made smaller by reducing degrees).
- Adding a card and removing a card from the hand changes the angle of each card, changing the spread. Additions + removals can happen anywhere on the spread

## Cards
- Initially I didn’t want to implement different card types, but it really helped for debugging to import playing card assets and use them over blank cards.
- Required enums for suit and rank, as well as Data class and Visualize script. The result is a modular card system.
- Layering and raycast collisions gave me a huge headache until I gave up and layered by z axis.

All in all, I learned how to make modular data classes alongside prefabs, how to make good looking Euclidian rotation in Unity, and how to use layered colliders. It took me around 10-15 hours to complete the program. The most challenging part was setting up supporting playing card classes and scripts. It required more abstract design thought that motivates me to make a game based off playing cards.
