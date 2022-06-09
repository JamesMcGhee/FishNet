# FishNet - Unity Networking Evolved

For more information on what this asset is capable of or how to use it please visit our **[Documentation](https://fish-networking.gitbook.io/docs)** or if you have questions please visit our [Discord](https://discord.gg/NqzSEqR).

* Author: [First Gear Games](https://github.com/sponsors/FirstGearGames)
* [License](https://github.com/heathen-engineering/FishNet/blob/main/Unity%20Project/Assets/com.firstgeargames.fishnet/LICENSE.txt)
* [Documentation](https://fish-networking.gitbook.io/docs)
* [Support](https://discord.gg/NqzSEqR)

## Donations
* [Github sponsor](https://github.com/sponsors/FirstGearGames) (preferred)
* [Gofundme](https://www.gofundme.com/f/fishnet)
* [Patreon](https://www.patreon.com/firstgeargames)
  
## Installation
* Package Manager
1) Open the package manager and click the '+' (plus) button located in the upper left of the window
2) Select `Add package from git URL...` when prompted provide the following URL:  
`https://github.com/heathen-engineering/FishNet.git?path=/Unity%20Project/Assets/com.firstgeargames.fishnet`  

## Description
A feature-rich Unity networking solution aimed towards reliability, ease of use, efficiency, and flexibility. Developed by a professional game designer, supported by the community.

This repository is set up to support local development, import as a Unity Project or install via Unity Package Manager. The recomended method of installation is to use Unity Package Manager as this reduces risk of installation error, and simplifies import of related tools. You can however clone this repository and open the [Unity Project](https://github.com/heathen-engineering/FishNet/tree/main/Unity%20Project) folder as a Unity Project via the Unity Hub. You can also choose to copy and paste only the required folder [com.firstgeargames.fishnet](https://github.com/heathen-engineering/FishNet/tree/main/Unity%20Project/Assets/com.firstgeargames.fishnet) which is similar to what Unity Package Manager would do for you.

Note that if you do choose to copy the [com.firstgeargames.fishnet](https://github.com/heathen-engineering/FishNet/tree/main/Unity%20Project/Assets/com.firstgeargames.fishnet) in manually you will need to change the names of the Sample and Plugin folder to remove the ~ character. This character will cause Unity to ignore those folders and so they will not show in editor. These are here to allow UPM (Unity Package Manager) to import these on demand as part of the samples in the Package Manager drop down.

![image](https://user-images.githubusercontent.com/31243736/172846105-8398053a-0b1c-4224-ad26-ec612e74b1a7.png)

The above image shows Fishy Networking installed via the Unity Package Manager (UPM) with its samples expanded, you can then click import on any sample to import it into your project.

## Plugins
Fish Networking supports a number of transports, each is listed below, note that if you install Fish Networking via the Unity Package Manager (UPM) as recomended these can be imported with a single click by expanding the samples drop down in the Unity Package Manager (UPM) window and importing the desired plugin.
### Fishy Steamworks
A Steam Networking Socket transport capable of Peer to Peer and Client Server networking over Steam API's Steam Netwokring Socket interface. This plugin is dependent on [Steamworks.NET](https://github.com/rlabrecque/Steamworks.NET). The plugin includes tools to help you install [Steamworks.NET](https://github.com/rlabrecque/Steamworks.NET) at the push of a button as well as tools to help you install various extensions of [Steamworks.NET](https://github.com/rlabrecque/Steamworks.NET) that can make working with Steam signifigantly easier.

To import Fishy Steamworks its strongly recomended that you use the Unity Package Manager (UPM) to import FIshy Steamworks. You can however manually import the code and it will work as intended. To manually import simply copy the [FishyNetworking](https://github.com/heathen-engineering/FishNet/tree/main/Unity%20Project/Assets/Plugins/FishySteamworks) folder into your project.

![image](https://user-images.githubusercontent.com/31243736/172847500-0afd0fa8-8141-40d3-a824-b3dd6bff7858.png)

Once imported you will have a new Tools menu under the Fish-Networking menu header. There you can install or upgrade [Steamworks.NET](https://github.com/rlabrecque/Steamworks.NET) or you can choose to install [Heathen's Steamworks Foundation](https://github.com/heathen-engineering/SteamworksFoundation), or [Heathen's Steamworks Complete](https://www.heathen.group/steamworks). 
> [Steamworks Complete](https://www.heathen.group/steamworks) is only available to [Heathen's GitHub Sponsors](https://github.com/sponsors/heathen-engineering), [Steamworks Foundaiton](https://github.com/heathen-engineering/SteamworksFoundation) is a free and open source "lite" version of it. 

> What about SteamManager.cs?
> That should never have been used and was a sample script from [Steamworks.NET](https://github.com/rlabrecque/Steamworks.NET)'s author. It had a number of limitations which would be problematice for your game over time. For a quick, easy to use and free alternative look at [Steamworks Foundaiton](https://github.com/heathen-engineering/SteamworksFoundation) or if you prefer look at the examples from [Steamworks.NET](https://github.com/rlabrecque/Steamworks.NET)'s author and write your own.

