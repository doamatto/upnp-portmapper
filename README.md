# UPnP-PortMapper

The name says it all; this is a UPnP-based port mapper for people who don't want to port forward, want to take the easy way, or (like myself) have no clue why their portforwarding isn't working. The main issues is that all the port mappers I've seen have a few things in common (and it makes little sense to me, actually): they're written in Java, they don't work, and they don't have someone actively working on fixing bugs and other issues. In other words, it's a classic case of "Guess I've got to do it myself."

This is a command-line based utility mainly because I run a headless server, which means a GUI wouldn't work. In the future, I might add a lightweight GUI using GTK+. Why GTK+? Because this is also a cross-platform utility and having one source base is **WAY** easier then making several repos for each version (Windows, macOS, Linux) of this utility. It's easier to hit compile and upload binaries to one repo in one project file.

### Building
I built this tool with [VS.2019](https://visualstudio.com), as I recommend you do as well. However, you can still compile without VS.2019 by using MSBuild™ (the ™ is because I haven't tried using MSBuild).

**Via Visual Studio 2019**
Open `upnp-portmapper.sln` in VS.2019. After ensuring everything has loaded properly, you can do `Ctrl`+`B` or go to the menu bar at the top of the window, select on `Build`, and then click the build button. You should now have a binary that you can use to run the CLI app.

**Via MSBuild**
Run this command:
```sh
MSBuild upnp-portmapper/upnp-portmapper.proj -property:Configuration=Debug
```

### Usage
I don't even know yet. Once I find out how I'm going to make this work, it'll be in [the wiki, along with everything else](https://github.com/doamatto/upnp-portmapper/wiki)

### Acknowledgements
Thanks to [Lucas Ontivero](https://github.com/lontivero) for making the fork of Mono.Nat (which is Open.Nat) and documenting it well.