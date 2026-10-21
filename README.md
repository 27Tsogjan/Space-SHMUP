# Space Shmup by Rachel Lutsky and Janice Tsogbe

Project 3 in CS382 is a classic vertical space shoot-'em-up built in Unity, following the SHMUP project from Introduction to Game Design, Prototyping, and Development's chapter 32 tutorial. Fly your ship, shoot waves of enemies, collect power-ups, and survive as long as you can.

## Controls

| Input | Action |
|---|---|
| Arrow keys/WASD | Move the ship |
| Space | Fire weapons |

## Features

- **Five enemy types** (`Enemy_0` to `Enemy_4`), each with its own movement pattern:
  - `Enemy_0`: flies straight down
  - `Enemy_1`: sine-wave sway
  - `Enemy_2`: diagonal sweep with a spin
  - `Enemy_3`: curved Bezier path
  - `Enemy_4`: shielded ship that moves between random points
- **Bonus enemy** (`Enemy_5`): speeds up once it passes a set height on the screen.
- **Weapons and power-ups:** blaster and spread shot, plus shield power-ups dropped by destroyed enemies.
- **Player damage:** enemies that touch the ship lower its shield level. The ship is destroyed when the shield drops below zero.
- **Scrolling starfield:** a parallax background that scrolls continuously and shifts slightly as the ship moves.

## Enhancements

- **Scoring system:** each enemy is worth a different number of points, shown in the top-left corner.

  | Enemy | Points |
  |---|---|
  | Enemy_0 | 100 |
  | Enemy_1 | 150 |
  | Enemy_2 | 200 |
  | Enemy_3 | 250 |
  | Enemy_4 | 400 |
  | Enemy_5 | 500 |

- **Game over screen:** shows "GAME OVER" and the final score before the scene restarts.
- **Bonus enemy:** `Enemy_5` is a sixth, faster-moving, high-value enemy.

## Project Structure

| Script | Purpose |
|---|---|
| `Hero.cs` | Player movement, shooting, shield level, power-up pickup |
| `Weapon.cs` | Weapon types, definitions, and projectile creation |
| `ProjectileHero.cs` | Player projectiles |
| `Enemy.cs`, `Enemy_0.cs` to `Enemy_5.cs` | Enemy base class and subclasses |
| `EnemyShield.cs` | Shields for `Enemy_4` |
| `BlinkColorOnHit.cs` | Flashes a ship red when hit |
| `Main.cs` | Enemy spawning, scoring, game over, and restart |
| `PowerUp.cs` | Collectible power-ups |
| `Shield.cs` | Visual display of the hero's shield level |
| `Parallax.cs` | Scrolling starfield background |
| `BoundsCheck.cs` | Keeps objects on screen or detects when they leave |
| `Utils.cs` | Bezier curve and material helper functions |