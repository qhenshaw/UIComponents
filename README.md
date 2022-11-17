# UI Components
[![Unity 2021.1+](https://img.shields.io/badge/unity-2020.1%2B-blue.svg)](https://unity3d.com/get-unity/download)
[![License: MIT](https://img.shields.io/badge/License-MIT-brightgreen.svg)](LICENSE.md)

A set of helpful UGUI components that handle:
- scene switching
- controller/keyboard selection (using the Input System)
  - switching action maps
- cursor lock modes
- paushing/unpausing time
- settings menus
  - gamma sliders
  - audio mixer parameter sliders
  - FMOD parameter sliders

## System Requirements
Unity 2021.1+. Will likely work on earlier versions but this is the version I tested with.


## Installation
Use the Package Manager and use Add package from git URL, using the following: 
```
https://github.com/qhenshaw/UIComponents.git
```
Requires the following Unity Packages:
```
Unity UI
Input System
Core RP Library
Universal RP
```
*FMOD integration is optional.*  
**To enable FMOD support for settings sliders, add 'FMOD' to your Scripting Define Symbols in Project Settings => Player.**

## Usage
Most of the components are fairly simple but the menu hierarchy structure required is complex.

I recommend importing the Main Menu sample and then customizing your UI using that as a base.
