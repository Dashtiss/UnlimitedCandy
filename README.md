# UnlimitedCandy Exiled Plugin

UnlimitedCandy is an Exiled plugin designed to modify the interaction behavior with SCP-330 (the candy bowl) in the game SCP: Secret Laboratory. With this plugin, you can control the maximum number of candies that players can receive from SCP-330, allowing you to customize the gameplay experience.

## Table of Contents
- [Installation](#installation)
- [Usage](#usage)
- [Configuration](#configuration)
- [Debugging](#debugging)
- [Contribution](#contribution)
- [License](#license)

## Installation

To install the UnlimitedCandy plugin, follow these steps:

1. **Prerequisites:** Ensure you have Exiled and SCP: Secret Laboratory server set up and running.

2. **Download:** Download the latest release of the plugin from the [Releases](https://github.com/YourGitHubUsername/UnlimitedCandy](https://github.com/Dashtiss/UnlimitedCandy)/releases) page.

3. **Installation:**
   - Extract the plugin files from the release to your server's `Exiled/Plugins` directory.
   - Make sure the `UnlimitedCandy.dll` and any associated files are in the right location.

4. **Configuration:**
   - Navigate to the `Exiled/Configs` directory and edit the `UnlimitedCandy.yml` configuration file to customize the behavior of the plugin (see [Configuration](#configuration) for details).
   - Save the configuration file.

5. **Start or Restart Server:** Start or restart your SCP: Secret Laboratory server to load the plugin.

## Usage

UnlimitedCandy modifies the behavior of interactions with SCP-330 based on your configuration settings. By default, it allows players to receive an unlimited number of candies from SCP-330. You can customize the plugin's behavior by adjusting the configuration settings.

## Configuration

The configuration  allows you to control how much candy a player can get: defauls are below:

- `IsEnabled`: Set this option to `true` to enable the plugin, or `false` to disable it. Default = true

- `Debug`: Enable debugging by setting this option to `true`. Debugging can be useful for troubleshooting any issues with the plugin. Default = false

- `Max`: This option controls the maximum number of candies a player can get from SCP-330. Set it to `-1` to disable the limit (allow unlimited candies), or specify a positive integer to limit the number of candies a player can receive. Default = -1

Example configuration:
```yaml
UnlimitedCandy:
  IsEnabled: true
  Debug: false
  Max: -1 # Unlimited candies by default
```
Contribution
Contributions to this project are welcome! If you have ideas for improvements or want to report issues, please open an issue or a PR on the GitHub repository.

License
This plugin is distributed under the MIT License. See the LICENSE file for more details.
