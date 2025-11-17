# Space Survivor  
## Unity Project –  3. Prefabs & Triggers Assignment  

## Author:
👤 Raphaël Coeffic — 337614747

---

## 🎮 Play the Game  
Itch.io Link: https://raphael-coeffic.itch.io/03-homework

---

## 📝 Game Description  
Space Survivor is a fast-paced 2D arcade shooter made in Unity.  
You control a small spaceship, destroy enemies, collect hearts, survive waves, and try to achieve the highest score.
This project was developed for the Game Development Course in university.

---

## How to Play:  

- Move with the Arrow Keys  
- Shoot with Space 
- Score: +1 for each enemy destroyed (shown top-right)  
- Lives: you start with 3 hearts  
- Colliding with an enemy = –1 life  
- Heart pickups restore 1 life (max 3)  
- When lives reach 0 it's Game Over
- When you finish the levels you win.

---

## Features Added for the Assignment  

### 1. Score displayed in a fixed corner  
- The score no longer follows the spaceship.  
- It now appears in the top-left corner and it is responsive.


### 2. Heart-based life system  
- Player starts with 3 lives.  
- A custom HeartsUI displays full/faded hearts.  
- At 0 lives → GameOver scene.
- Random spawns of hearths via `HeartSpawner`.  
- Pickups disappear after a few seconds.  
- Collecting one restores life (max capped).

### 3. Music 
Background music on the game, a music of game over and a music for victory

### 4. Animated scrolling background  
- Vertical movement creates a dynamic “space-travel” effect.


