# Unity Count to Ten

A simple 2D Unity application with three screens, demonstrating scene navigation, persistent data storage, and basic UI interaction using PlayerPrefs.

## Features

- **Welcome Screen** — User enters their name (validated, non-empty). Automatically skipped on future app launches if a name already exists.
- **Counter Screen** — Increment (+1) / Decrement (-1) buttons with persistent storage. Automatically navigates to the Congratulations screen once the value reaches 10.
- **Congratulations Screen** — Displays a personalized success message using the saved username.

## Screenshots

### Welcome Screen
![Welcome Screen](Screenshots/welcome_screen.png)

### Counter Screen
![Counter Screen](Screenshots/counter_screen.png)

### Congratulations Screen
![Congrats Screen](Screenshots/congrats_screen.png)


## How It Works

1. User enters their name on the Welcome Screen — saved using `PlayerPrefs`.
2. If the app is reopened, the Welcome Screen is automatically skipped since the name already exists.
3. On the Counter Screen, the user can increment or decrement a value using buttons.
4. The counter value persists across app sessions using `PlayerPrefs`.
5. Once the counter reaches 10, counter value will be saved using `PlayerPrefs` and navigates to the Congratulations Screen.
6. The Congratulations Screen greets the user by their saved name.



## Key Concepts Used

- **Scene Management** — `SceneManager.LoadScene()` for navigation between screens
- **Data Persistence** — `PlayerPrefs.SetString()` / `GetString()` / `SetInt()` / `GetInt()`
- **Input Validation** — Non-empty check with `string.IsNullOrEmpty()`
- **UI Components** — TMP_InputField, TMP_Text, Button (Unity UI / TextMeshPro)



## Author

**Foisal Ahmed Fahim**
[GitHub](https://github.com/fahimx51)
