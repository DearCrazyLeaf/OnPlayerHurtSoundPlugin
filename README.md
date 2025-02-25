# OnPlayerHurtSoundPlugin for Counter-Strike 2

## Overview

**OnPlayerHurtSoundPlugin** is a custom plugin for Counter-Strike 2 servers, designed to enhance the gameplay experience by playing a random sound whenever a player is hurt. This plugin adds a unique auditory element to the game, making it more immersive and engaging for players.

## Key Features

- **Custom Hurt Sounds:** Play a random sound from a predefined list whenever a player is hurt.
- **Configurable Sound List:** Administrators can easily customize the list of hurt sounds through a configuration file.
- **Event-Driven:** The plugin triggers sounds based on the `EventPlayerHurt` event, ensuring seamless integration with the game's mechanics.
- **Localization Support:** The plugin supports localization, allowing for multilingual server messages.

## Usage

To utilize the OnPlayerHurtSoundPlugin, follow these steps:

1. **Installation:** Acquire the plugin from the [GitHub repository](https://github.com/hlymcn/OnPlayerHurtSoundPlugin) and place it in your server's plugin directory.
2. **Configuration:** Customize the plugin by editing the `OnPlayerHurtSoundPlugin` file to add or modify hurt sounds.
3. **Activation:** Upon activation, the plugin will automatically play a random hurt sound whenever a player is damaged.

## Requirements

- CounterStrikeSharp: [CounterStrikeSharp](https://github.com/roflmuffin/CounterStrikeSharp)
- MetaMod: [MetaMod](https://www.metamodsource.net/downloads.php?branch=dev)

## Installation

1. Clone the repository or download the latest release from [GitHub](https://github.com/hlymcn/OnPlayerHurtSoundPlugin).
2. Copy the plugin files to `...\addons\counterstrikesharp\plugins\OnPlayerHurtSoundPlugin`.
3. Edit the configuration file `...\addons\counterstrikesharp\configs\plugins\OnPlayerHurtSoundPlugin\OnPlayerHurtSoundPlugin.json` to set up your hurt sounds.
4. Ensure your server meets the API version requirements and adjust settings as necessary.

## Contribution and Support

We encourage community contributions. For suggestions or to report issues, please submit a pull request or open an issue on the [GitHub repository](https://github.com/hlymc/nOnPlayerHurtSoundPlugin). Your input is crucial for the ongoing development of the plugin.

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## Conclusion

The OnPlayerHurtSoundPlugin is a fun and engaging addition to Counter-Strike 2 servers, adding a unique auditory element to the game. Its easy setup and customizable features make it an excellent choice for server administrators looking to enhance their players' experience.
