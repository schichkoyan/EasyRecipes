<div align="center">
<h1 align="center">
<img src="https://raw.githubusercontent.com/PKief/vscode-material-icon-theme/ec559a9f6bfd399b82bb44393651661b08aaf7ba/icons/folder-markdown-open.svg" width="100" />
<br>EasyRecipes
</h1>
<h3>◦ HTTPStatus Exception: 429</h3>
<h3>◦ Developed with the software and tools below.</h3>

<p align="center">
<img src="https://img.shields.io/badge/XAML-0C54C2.svg?style&logo=XAML&logoColor=white" alt="XAML" />
<img src="https://img.shields.io/badge/JSON-000000.svg?style&logo=JSON&logoColor=white" alt="JSON" />
</p>
<img src="https://img.shields.io/github/languages/top/schichkoyan/EasyRecipes?style&color=5D6D7E" alt="GitHub top language" />
<img src="https://img.shields.io/github/languages/code-size/schichkoyan/EasyRecipes?style&color=5D6D7E" alt="GitHub code size in bytes" />
<img src="https://img.shields.io/github/commit-activity/m/schichkoyan/EasyRecipes?style&color=5D6D7E" alt="GitHub commit activity" />
<img src="https://img.shields.io/github/license/schichkoyan/EasyRecipes?style&color=5D6D7E" alt="GitHub license" />
</div>

---

## 📖 Table of Contents
- [📖 Table of Contents](#-table-of-contents)
- [📍 Overview](#-overview)
- [📦 Features](#-features)
- [📂 Repository Structure](#-repository-structure)
- [⚙️ Modules](#modules)
- [🚀 Getting Started](#-getting-started)
    - [🔧 Installation](#-installation)
    - [🤖 Running EasyRecipes](#-running-EasyRecipes)
    - [🧪 Tests](#-tests)
- [🛣 Roadmap](#-roadmap)
- [🤝 Contributing](#-contributing)
- [📄 License](#-license)
- [👏 Acknowledgments](#-acknowledgments)

---


## 📍 Overview

HTTPStatus Exception: 429

---

## 📦 Features

HTTPStatus Exception: 429

---


## 📂 Repository Structure

```sh
└── EasyRecipes/
    ├── EasyRecipes/
    │   ├── .DS_Store
    │   ├── App.xaml
    │   ├── App.xaml.cs
    │   ├── AssemblyInfo.cs
    │   ├── Constants.cs
    │   ├── DependencyInjectionContainer.cs
    │   ├── EasyRecipes.csproj
    │   ├── Interfaces/
    │   │   ├── IDbService.cs
    │   │   ├── IServiceOverridable.cs
    │   │   └── SpoonacularService.cs
    │   ├── IocProvider.cs
    │   ├── Models/
    │   │   ├── Recipe.cs
    │   │   └── User.cs
    │   ├── NavigationDispatcher.cs
    │   ├── Services/
    │   │   ├── RecipeDb.cs
    │   │   ├── Spoonacular.cs
    │   │   └── UserService.cs
    │   ├── ViewModels/
    │   │   ├── BaseViewModel.cs
    │   │   ├── LoginViewModel.cs
    │   │   ├── RecipeDetailsViewModel.cs
    │   │   └── RecipesViewModel.cs
    │   └── Views/
    │       ├── LoginView.xaml
    │       ├── LoginView.xaml.cs
    │       ├── RecipeDetailsView.xaml
    │       ├── RecipeDetailsView.xaml.cs
    │       ├── RecipesView.xaml
    │       └── RecipesView.xaml.cs
    ├── EasyRecipes.Android/
    │   ├── Assets/
    │   │   └── AboutAssets.txt
    │   ├── EasyRecipes.Android.csproj
    │   ├── MainActivity.cs
    │   ├── Properties/
    │   │   ├── AndroidManifest.xml
    │   │   └── AssemblyInfo.cs
    │   └── Resources/
    │       ├── AboutResources.txt
    │       ├── Resource.designer.cs
    │       ├── drawable/
    │       │   ├── Easy Recipes-logos.jpeg
    │       │   ├── Easy Recipes-logos_black.png
    │       │   ├── Easy Recipes-logos_transparent.png
    │       │   ├── Easy Recipes-logos_white.png
    │       │   └── logo_info.txt
    │       ├── mipmap-anydpi-v26/
    │       │   ├── icon.xml
    │       │   └── icon_round.xml
    │       ├── mipmap-hdpi/
    │       │   ├── icon.png
    │       │   └── launcher_foreground.png
    │       ├── mipmap-mdpi/
    │       │   ├── icon.png
    │       │   └── launcher_foreground.png
    │       ├── mipmap-xhdpi/
    │       │   ├── icon.png
    │       │   └── launcher_foreground.png
    │       ├── mipmap-xxhdpi/
    │       │   ├── icon.png
    │       │   └── launcher_foreground.png
    │       ├── mipmap-xxxhdpi/
    │       │   ├── icon.png
    │       │   └── launcher_foreground.png
    │       └── values/
    │           ├── colors.xml
    │           └── styles.xml
    ├── EasyRecipes.iOS/
    │   ├── AppDelegate.cs
    │   ├── Assets.xcassets/
    │   │   └── AppIcon.appiconset/
    │   │       ├── 120-1.png
    │   │       ├── 120.png
    │   │       ├── 152.png
    │   │       ├── 167.png
    │   │       ├── 180.png
    │   │       ├── 20.png
    │   │       ├── 29.png
    │   │       ├── 40-1.png
    │   │       ├── 40-2.png
    │   │       ├── 40.png
    │   │       ├── 58-1.png
    │   │       ├── 58.png
    │   │       ├── 60.png
    │   │       ├── 76.png
    │   │       ├── 80-1.png
    │   │       ├── 80.png
    │   │       ├── 87.png
    │   │       ├── Contents.json
    │   │       └── appstore.png
    │   ├── EasyRecipes.iOS.csproj
    │   ├── Entitlements.plist
    │   ├── Info.plist
    │   ├── Main.cs
    │   ├── Properties/
    │   │   └── AssemblyInfo.cs
    │   └── Resources/
    │       ├── Easy Recipes-logos.jpeg
    │       ├── Easy Recipes-logos_black.png
    │       ├── Easy Recipes-logos_transparent.png
    │       ├── Easy Recipes-logos_white.png
    │       ├── LaunchScreen.storyboard
    │       └── logo_info.txt
    └── EasyRecipes.sln
```


---

## ⚙️ Modules

<details closed><summary>Root</summary>

| File                                                                                    | Summary                   |
| ---                                                                                     | ---                       |
| [EasyRecipes.sln](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes.sln) | HTTPStatus Exception: 429 |

</details>

<details closed><summary>Easyrecipes</summary>

| File                                                                                                                                | Summary                   |
| ---                                                                                                                                 | ---                       |
| [NavigationDispatcher.cs](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes/NavigationDispatcher.cs)                 | HTTPStatus Exception: 429 |
| [IocProvider.cs](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes/IocProvider.cs)                                   | HTTPStatus Exception: 429 |
| [Constants.cs](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes/Constants.cs)                                       | HTTPStatus Exception: 429 |
| [App.xaml.cs](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes/App.xaml.cs)                                         | HTTPStatus Exception: 429 |
| [EasyRecipes.csproj](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes/EasyRecipes.csproj)                           | HTTPStatus Exception: 429 |
| [DependencyInjectionContainer.cs](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes/DependencyInjectionContainer.cs) | HTTPStatus Exception: 429 |
| [App.xaml](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes/App.xaml)                                               | HTTPStatus Exception: 429 |
| [AssemblyInfo.cs](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes/AssemblyInfo.cs)                                 | HTTPStatus Exception: 429 |

</details>

<details closed><summary>Views</summary>

| File                                                                                                                          | Summary                   |
| ---                                                                                                                           | ---                       |
| [RecipesView.xaml](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes/Views/RecipesView.xaml)                   | HTTPStatus Exception: 429 |
| [LoginView.xaml](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes/Views/LoginView.xaml)                       | HTTPStatus Exception: 429 |
| [RecipeDetailsView.xaml](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes/Views/RecipeDetailsView.xaml)       | HTTPStatus Exception: 429 |
| [LoginView.xaml.cs](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes/Views/LoginView.xaml.cs)                 | HTTPStatus Exception: 429 |
| [RecipeDetailsView.xaml.cs](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes/Views/RecipeDetailsView.xaml.cs) | HTTPStatus Exception: 429 |
| [RecipesView.xaml.cs](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes/Views/RecipesView.xaml.cs)             | HTTPStatus Exception: 429 |

</details>

<details closed><summary>Viewmodels</summary>

| File                                                                                                                               | Summary                   |
| ---                                                                                                                                | ---                       |
| [LoginViewModel.cs](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes/ViewModels/LoginViewModel.cs)                 | HTTPStatus Exception: 429 |
| [RecipeDetailsViewModel.cs](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes/ViewModels/RecipeDetailsViewModel.cs) | HTTPStatus Exception: 429 |
| [BaseViewModel.cs](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes/ViewModels/BaseViewModel.cs)                   | HTTPStatus Exception: 429 |
| [RecipesViewModel.cs](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes/ViewModels/RecipesViewModel.cs)             | HTTPStatus Exception: 429 |

</details>

<details closed><summary>Models</summary>

| File                                                                                           | Summary                   |
| ---                                                                                            | ---                       |
| [User.cs](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes/Models/User.cs)     | HTTPStatus Exception: 429 |
| [Recipe.cs](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes/Models/Recipe.cs) | HTTPStatus Exception: 429 |

</details>

<details closed><summary>Interfaces</summary>

| File                                                                                                                         | Summary                   |
| ---                                                                                                                          | ---                       |
| [SpoonacularService.cs](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes/Interfaces/SpoonacularService.cs)   | HTTPStatus Exception: 429 |
| [IServiceOverridable.cs](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes/Interfaces/IServiceOverridable.cs) | HTTPStatus Exception: 429 |
| [IDbService.cs](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes/Interfaces/IDbService.cs)                   | HTTPStatus Exception: 429 |

</details>

<details closed><summary>Services</summary>

| File                                                                                                       | Summary                   |
| ---                                                                                                        | ---                       |
| [UserService.cs](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes/Services/UserService.cs) | HTTPStatus Exception: 429 |
| [RecipeDb.cs](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes/Services/RecipeDb.cs)       | HTTPStatus Exception: 429 |
| [Spoonacular.cs](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes/Services/Spoonacular.cs) | HTTPStatus Exception: 429 |

</details>

<details closed><summary>Easyrecipes.android</summary>

| File                                                                                                                              | Summary                   |
| ---                                                                                                                               | ---                       |
| [MainActivity.cs](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes.Android/MainActivity.cs)                       | HTTPStatus Exception: 429 |
| [EasyRecipes.Android.csproj](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes.Android/EasyRecipes.Android.csproj) | HTTPStatus Exception: 429 |

</details>

<details closed><summary>Properties</summary>

| File                                                                                                                   | Summary                   |
| ---                                                                                                                    | ---                       |
| [AssemblyInfo.cs](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes.Android/Properties/AssemblyInfo.cs) | HTTPStatus Exception: 429 |
| [AssemblyInfo.cs](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes.iOS/Properties/AssemblyInfo.cs)     | HTTPStatus Exception: 429 |

</details>

<details closed><summary>Assets</summary>

| File                                                                                                               | Summary                   |
| ---                                                                                                                | ---                       |
| [AboutAssets.txt](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes.Android/Assets/AboutAssets.txt) | HTTPStatus Exception: 429 |

</details>

<details closed><summary>Resources</summary>

| File                                                                                                                              | Summary                                 |
| ---                                                                                                                               | ---                                     |
| [AboutResources.txt](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes.Android/Resources/AboutResources.txt)       | HTTPStatus Exception: 429               |
| [Resource.designer.cs](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes.Android/Resources/Resource.designer.cs)   | Prompt exceeds max token limit: 104506. |
| [LaunchScreen.storyboard](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes.iOS/Resources/LaunchScreen.storyboard) | HTTPStatus Exception: 429               |
| [logo_info.txt](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes.iOS/Resources/logo_info.txt)                     | HTTPStatus Exception: 429               |

</details>

<details closed><summary>Drawable</summary>

| File                                                                                                                       | Summary                   |
| ---                                                                                                                        | ---                       |
| [logo_info.txt](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes.Android/Resources/drawable/logo_info.txt) | HTTPStatus Exception: 429 |

</details>

<details closed><summary>Easyrecipes.ios</summary>

| File                                                                                                                  | Summary                   |
| ---                                                                                                                   | ---                       |
| [AppDelegate.cs](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes.iOS/AppDelegate.cs)                 | HTTPStatus Exception: 429 |
| [Main.cs](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes.iOS/Main.cs)                               | HTTPStatus Exception: 429 |
| [Info.plist](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes.iOS/Info.plist)                         | HTTPStatus Exception: 429 |
| [Entitlements.plist](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes.iOS/Entitlements.plist)         | HTTPStatus Exception: 429 |
| [EasyRecipes.iOS.csproj](https://github.com/schichkoyan/EasyRecipes/blob/main/EasyRecipes.iOS/EasyRecipes.iOS.csproj) | HTTPStatus Exception: 429 |

</details>

---

## 🚀 Getting Started

***Dependencies***

Please ensure you have the following dependencies installed on your system:

`- ℹ️ Dependency 1`

`- ℹ️ Dependency 2`

`- ℹ️ ...`

### 🔧 Installation

1. Clone the EasyRecipes repository:
```sh
git clone https://github.com/schichkoyan/EasyRecipes
```

2. Change to the project directory:
```sh
cd EasyRecipes
```

3. Install the dependencies:
```sh
dotnet build
```

### 🤖 Running EasyRecipes

```sh
dotnet run
```

### 🧪 Tests
```sh
dotnet test
```

---


## 🛣 Roadmap

> - [X] `ℹ️  Task 1: Implement X`
> - [ ] `ℹ️  Task 2: Implement Y`
> - [ ] `ℹ️ ...`


---

## 🤝 Contributing

Contributions are always welcome! Please follow these steps:
1. Fork the project repository. This creates a copy of the project on your account that you can modify without affecting the original project.
2. Clone the forked repository to your local machine using a Git client like Git or GitHub Desktop.
3. Create a new branch with a descriptive name (e.g., `new-feature-branch` or `bugfix-issue-123`).
```sh
git checkout -b new-feature-branch
```
4. Make changes to the project's codebase.
5. Commit your changes to your local branch with a clear commit message that explains the changes you've made.
```sh
git commit -m 'Implemented new feature.'
```
6. Push your changes to your forked repository on GitHub using the following command
```sh
git push origin new-feature-branch
```
7. Create a new pull request to the original project repository. In the pull request, describe the changes you've made and why they're necessary.
The project maintainers will review your changes and provide feedback or merge them into the main branch.

---

## 📄 License

This project is licensed under the `ℹ️  LICENSE-TYPE` License. See the [LICENSE-Type](LICENSE) file for additional info.

---

## 👏 Acknowledgments

`- ℹ️ List any resources, contributors, inspiration, etc.`

---
