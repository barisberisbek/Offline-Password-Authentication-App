# Offline Password Authentication App

## Description

This project demonstrates that computers cannot generate truly random numbers, as they rely on algorithms that can be predicted with sufficient data. It highlights the importance of understanding pseudo-random number generation and its implications for security and encryption.

The application includes implementations of both TOTP (Time-based One-Time Password) and HOTP (HMAC-based One-Time Password) algorithms, showcasing the generation and validation of one-time passwords.

## Features

- Generates TOTP and HOTP passwords using two separate secret keys.
- Validates entered passwords against both TOTP and HOTP generated passwords.
- Displays the generated passwords and a countdown timer for TOTP validity.
- Supports offline password validation within a specified timeframe.

## Getting Started

### Prerequisites

- .NET Framework
- Visual Studio or any compatible C# IDE

### Installation

1. Clone the repository:
   ```sh
   git clone https://github.com/your-username/Offline-Password-Authentication-App.git
   Open the solution file in Visual Studio.

2. Open the solution file in Visual Studio.

3. Build and run the project.

Usage
Generate New Passwords: The application generates new TOTP and HOTP passwords every 60 seconds.
Validate Passwords: Enter the generated password into the input field and click the "Login" button to validate.
Algorithms
TOTP (Time-based One-Time Password): Uses the current time as a moving factor to generate a new password every 60 seconds.
HOTP (HMAC-based One-Time Password): Uses a counter as a moving factor, incrementing with each password generation.
Important Concepts
Pseudo-Random Number Generation: Demonstrates that computers generate pseudo-random numbers based on algorithms, which can be predicted with enough information.
Security Implications: Highlights the importance of understanding the limitations of pseudo-random number generation in security and encryption contexts.
