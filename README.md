Meow Adventure(2D Platformer) 🐱

A 2D pixel-art platformer developed in Unity. This project was originally built as a personalized gift, featuring custom level design and interactive audio mechanics.

Key Features
* **Character Controller:** Custom 2D physics-based movement including jumping, crouching, and air control.
* **Audio Interaction:** "Press F to Meow" mechanic using AudioSource handling.
* **Level System:** Sequential level progression with trigger-based victory conditions.
* **Event System:** Uses `UnityEvents` for handling state changes (Landing, Crouching) to decouple animation logic from physics.

Technical Implementation
* **Engine:** Unity 2022.3
* **Language:** C#
* **Physics:** `Physics2D.OverlapCircle` for precise ground and ceiling detection.
* **Architecture:** Modular scripts separating *Input* (`PlayerMovement.cs`) from *Physics* (`CharacterController2D.cs`).

Note on Assets
*Some personal image assets used in the original build have been excluded from this public repository for privacy reasons. The core gameplay and code remain fully functional.*
