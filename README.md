<div align="center">

  <img width="450" alt="PS3TrophyIsGood — JSON Edition" src="https://github.com/user-attachments/assets/b50c400f-6f04-4b0e-8edb-481ad889c444" />

  # PS3TrophyIsGood — JSON Edition

  **A modern, lightweight fork of PS3TrophyIsGood with JSON Export & Import.**  
  *Generate natural, realistic trophy timelines manually or with AI assistants like ChatGPT, Claude, Gemini, and DeepSeek.*

  <br/>

  [![Release](https://img.shields.io/github/v/release/TYFALY/PS3TrophyIsGood-JSON?style=for-the-badge&color=007ACC&logo=github)](https://github.com/TYFALY/PS3TrophyIsGood-JSON/releases/latest)
  [![Platform](https://img.shields.io/badge/Platform-Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white)](#-building)
  [![Target](https://img.shields.io/badge/Framework-.NET_Desktop-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
  [![Compatibility](https://img.shields.io/badge/Compatibility-PS3%20%7C%20RPCS3-003791?style=for-the-badge&logo=playstation)](#-about)
  [![AI Ready](https://img.shields.io/badge/AI-ChatGPT%20%7C%20Claude%20%7C%20DeepSeek-10a37f?style=for-the-badge&logo=openai)](#-universal-ai-prompt)

  <br/>

  [📥 Download Latest Release](https://github.com/TYFALY/PS3TrophyIsGood-JSON/releases) •
  [✨ What's New](#-whats-new) •
  [📋 JSON Workflow](#-json-workflow) •
  [🤖 Universal AI Prompt](#-universal-ai-prompt) •
  [🛠️ Build Guide](#-building)

</div>

---
## ✨ What's New

This fork introduces a streamlined **JSON Export / Import** workflow while preserving every feature from the original **PS3TrophyIsGood** application.

| Feature | Description |
| :--- | :--- |
| 📤 **Export to JSON** | Dump full trophy sets and timestamps into clean, human-readable JSON format with a single click. |
| 📥 **Import from JSON** | Seamlessly load modified JSON files back into the application with automatic validation. |
| 🤖 **AI-Assisted Timelines** | Generate believable, human-like trophy progression using ChatGPT, Claude, Gemini, DeepSeek, or any LLM. |
| 📝 **External Batch Editing** | Edit, inspect, or batch-modify timestamps in your favorite editor (VS Code, Notepad++, Sublime). |

> [!TIP]
> **Why JSON?**  
> Instead of manually clicking and changing every timestamp one-by-one inside the GUI, JSON enables instant batch editing, automated scripting, and effortless compatibility with modern AI models for realistic timestamp generation.

---

## 🎮 Preserved Original Features

Every core capability from **darkautism's** original project remains 100% intact:

* **Complete Trophy Editing:** Unlock, lock, edit timestamp values, and update individual trophy states.
* **RPCS3 & Real Hardware Support:** Compatible with decrypted trophy folders from both physical PS3 consoles and the RPCS3 emulator.
* **Trophy Resigning:** Built-in resigning tools to ensure your trophy files match your target account ID (`PARAM.SFO` / `TROPTRNS.DAT`).
* **Smart Copy:** Easily clone and synchronize trophy profiles between different sets.
* **Multi-Language Interface:** Full internationalization support with multiple community translations.

---
## About

This repository is a lightweight fork of **PS3TrophyIsGood** by **darkautism**.

The **only functional addition** is support for **JSON Export** and **JSON Import**, allowing trophy data and timestamps to be edited outside the GUI before being imported back.

All core capabilities—including direct trophy editing, timestamp manipulation, RPCS3 support, trophy resigning, Smart Copy, and multi-language support—come directly from the upstream project without modification.

This fork is designed as a quality-of-life upgrade for users who want a faster workflow for batch editing, custom automation scripts, or AI-assisted realistic timestamp generation.

---

## JSON Workflow

```text
┌─────────────────┐       File -> Export       ┌─────────────────┐
│  Trophy Folder  │ ─────────────────────────> │   trophies.json │
│   (TROPCONF)    │                            └────────┬────────┘
└─────────────────┘                                     │
         ▲                                              │  Edit via LLM /
         │                                              │  Text Editor
         │             File -> Import                   ▼
         └───────────────────────────────────── ┌─────────────────┐
                     Save & Resign              │   Edited JSON   │
                                                └─────────────────┘
```

### Step-by-Step Guide

1. **Open Trophy Folder:** Launch the application, click **File → Open**, and select your target trophy folder (e.g., `NPWR00000_00`).
2. **Export to JSON:** Select **File → Export Trophies to JSON** and save the generated `.json` file to your PC.
3. **Modify Timestamps:** Open the JSON file in your text editor or pass it to an LLM alongside the recommended prompt below.
4. **Import to Application:** Select **File → Import Trophies from JSON** and select your modified `.json` file. The app will automatically validate and apply the new timestamps.
5. **Save & Resign:** Click **File → Save** (and resign the set to your Account ID if required).

---
## Universal AI Prompt

To generate natural, human-like trophy unlock timelines, copy the prompt below and provide it to your AI model (such as ChatGPT, Claude, Gemini, or DeepSeek) along with your exported `trophies.json` file.

> [!TIP]
> **How to use:** Paste the prompt into your AI chat, attach or paste the exported JSON content below it, and specify any custom context if desired (such as your preferred start year/date or completion timeframe).

<details>
<summary><b>Click to expand the AI System Prompt</b></summary>

```text
You are an expert in PlayStation trophy progression, trophy roadmaps, and realistic gameplay simulation.

Your task is to modify ONLY the trophy timestamps in the provided JSON while preserving the file structure exactly.

The goal is to generate a believable trophy timeline that could realistically belong to a genuine player.

GENERAL RULES

• Return ONLY valid JSON.
• Do NOT wrap the JSON in Markdown formatting.
• Do NOT explain your reasoning or include conversational text.
• Do NOT add comments.
• Do NOT rename fields.
• Do NOT add or remove trophies.
• Do NOT modify trophy names or descriptions.
• Do NOT modify trophy IDs.
• Do NOT modify unlock status.
• Preserve every object exactly as it appears.
• Preserve the exact JSON array order.

PROGRESSION LOGIC

• Trophy IDs do NOT represent chronological unlock order. Never use trophy IDs alone to determine progression.
• Determine the correct order by analyzing:
  - Trophy names and descriptions
  - Hidden trophies
  - Story progression and chapters
  - Side quests and optional content
  - Collectibles and milestones
  - Difficulty trophies
  - DLC packs
  - Platinum requirements
• If the game is known, use publicly available roadmap knowledge (e.g., PSNProfiles, PowerPyx, trophy roadmaps, walkthroughs).
• Cross-reference game flow to ensure progression is logical.
• Never copy another player's exact timestamps; create an original, realistic timeline.

PARTIALLY COMPLETED TROPHY SETS

If some trophies are already unlocked in the provided JSON:
• Treat those timestamps as real player reference points.
• Continue the remaining progression naturally from the latest existing timestamp.
• Do NOT modify existing timestamps unless explicitly instructed.
• Maintain realistic spacing between existing and newly generated trophies.

UNOBTAINABLE TROPHIES

If a trophy is unobtainable as of the requested timeline (e.g., due to discontinued online servers):
• Leave it exactly as it is.
• Do NOT fabricate timestamps for unobtainable trophies.
• Do NOT modify their unlock status.
• Continue generating timestamps only for obtainable trophies.

REALISM REQUIREMENTS

Simulate an authentic human playthrough. Account for:
• Story progression and cutscenes
• Exploration, navigation, and menu time
• Boss fights, deaths, and retries
• Grinding and repetitive tasks
• Realistic AFK breaks, meal breaks, and overnight sleep between sessions
• DLC progression order
• Platinum cleanup phase

The pacing should naturally vary:
• Tutorials unlock quickly.
• Boss and story trophies require meaningful playtime between milestones.
• Grinding trophies take hours of distributed effort.
• Collectibles are discovered throughout the playthrough unless cleaned up at the end.
• The Platinum trophy must be the final unlock.

TIMESTAMP QUALITY

Avoid obvious AI patterns:
• Do NOT end every timestamp with :00 or :30.
• Do NOT repeat the same seconds values across consecutive entries.
• Do NOT unlock trophies at perfectly fixed intervals.
• Do NOT generate duplicate timestamps.
• Randomize hours, minutes, and seconds naturally (00–59).
• Create realistic gaps, mixed with occasional rapid chains where appropriate.

FINAL VALIDATION

Before returning the output, verify:
✓ Output is valid JSON.
✓ Every trophy is present with identical IDs and field names.
✓ Array order is preserved.
✓ Only timestamps were modified.
✓ Story and gameplay progression is logically ordered.
✓ No duplicate timestamps exist.
✓ Unobtainable trophies remain untouched.
✓ The output matches the timeline of a genuine player.

Return ONLY the completed JSON.
```

</details>

---
## Building from Source

### Prerequisites

* [Git](https://git-scm.com/)
* [Visual Studio 2019 or newer](https://visualstudio.microsoft.com/) with the **.NET Desktop Development** workload installed

### Build Steps

```bash
# 1. Clone the repository and initialize submodules
git clone https://github.com/TYFALY/PS3TrophyIsGood-JSON.git
cd PS3TrophyIsGood-JSON
git submodule update --init --recursive
```

1. Open `PS3TrophyIsGood.sln` in Visual Studio.
2. Set the build configuration to **Release**.
3. Click **Build → Build Solution** (`Ctrl+Shift+B`).
4. The compiled executable will be generated in the `bin/Release` folder.

---

## Safety & Warning

> [!WARNING]
> Modifying trophy files and synchronizing them to the PlayStation Network (PSN) violates Sony's Terms of Service and may result in account penalties, leaderboards bans (e.g., PSNProfiles), or account suspension.  
> 
> **Always create an untouched backup of your original trophy folders before making edits.**

---

## Credits & Acknowledgments

* **[darkautism (PS3TrophyIsGood)](https://github.com/darkautism/PS3TrophyIsGood)** – Original application architecture, cryptography, resigning algorithms, and GUI implementation.
* **[TYFALY](https://github.com/TYFALY/PS3TrophyIsGood-JSON)** – JSON Export/Import integration, schema parsing, validation logic, and release maintenance.

---

## Support

If you find this tool helpful for your workflow or preservation projects, consider **starring the repository** on GitHub!

---

<div align="center">
  <sub><b>Disclaimer:</b> PlayStation, PS3, PSN, and related marks are trademarks or registered trademarks of Sony Interactive Entertainment Inc. This project is open-source and is not affiliated with, endorsed by, or associated with Sony.</sub>
</div>
