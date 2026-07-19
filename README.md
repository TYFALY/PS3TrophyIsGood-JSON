<div align="center">

# PS3TrophyIsGood — JSON Edition

A lightweight fork of **PS3TrophyIsGood** that adds **JSON Export** and **JSON Import**, making it easy to edit trophy data manually or with AI assistants like **ChatGPT**, **Claude**, **Gemini**, and **DeepSeek**.

<img width="800" height="450" alt="ezgif-38079738afa29035" src="https://github.com/user-attachments/assets/b50c400f-6f04-4b0e-8edb-481ad889c444" />

⭐ **If you find this project useful, consider leaving a star!**

</div>

---

## ✨ What's New

This fork introduces a simple JSON workflow while preserving every feature from the original project.

| Feature | Description |
|:--|:--|
| 📤 **Export to JSON** | Export trophy data to an editable JSON file. |
| 📥 **Import from JSON** | Import edited JSON files back into the application. |
| 🤖 **AI Friendly** | Generate realistic trophy timestamps using ChatGPT, Claude, Gemini, DeepSeek, or any LLM. |
| 📝 **Manual Editing** | Edit trophy data in any JSON editor before importing it back. |

> [!TIP]
> The JSON format is designed to work seamlessly with both AI assistants and manual editing, making trophy timestamp customization significantly easier.

---

## 📖 About

This repository is a lightweight fork of **PS3TrophyIsGood** by **darkautism**.

The **only functional addition** is support for **JSON Export** and **JSON Import**, allowing trophy data to be edited outside the application before being imported back.

Everything else—including **trophy editing**, **timestamp editing**, **RPCS3 support**, **trophy resigning**, **Smart Copy**, and **multi-language support**—comes directly from the original project.

This fork is intended as a small quality-of-life improvement for users who want a simpler workflow for manual editing, automation, or AI-assisted trophy timestamp generation.

## 🚀 Building

```bash
git clone https://github.com/TYFALY/PS3TrophyIsGood.git
cd PS3TrophyIsGood
git submodule init
git submodule update --recursive
```

Open the solution in **Visual Studio 2019+** with the **.NET Desktop Development** workload installed, then build normally.

---

## 📋 JSON Workflow

1. Open a trophy folder.
2. Select **File → Export Trophies to JSON**.
3. Edit the JSON manually or with an LLM.
4. Select **File → Import Trophies from JSON**.
5. Save the trophy data.

---

## 🤖 Universal AI Prompt

<details>
<summary><strong>Click to expand the recommended AI prompt</strong></summary>

```text
You are an expert in PlayStation trophy progression, trophy roadmaps, and realistic gameplay simulation.

Your task is to modify ONLY the trophy timestamps in the provided JSON while preserving the file exactly.

The goal is to generate a believable trophy timeline that could realistically belong to a genuine player.

GENERAL RULES

• Return ONLY valid JSON.
• Do NOT wrap the JSON in Markdown.
• Do NOT explain your reasoning.
• Do NOT add comments.
• Do NOT rename fields.
• Do NOT add or remove trophies.
• Do NOT modify trophy names.
• Do NOT modify trophy descriptions.
• Do NOT modify trophy IDs.
• Do NOT modify unlock status.
• Preserve every object exactly as it appears.
• Preserve the exact JSON array order.

IMPORTANT

The trophy ID is NOT the chronological unlock order.

Never use trophy IDs to determine progression.

Instead, determine the correct order by analyzing:

- Trophy names
- Trophy descriptions
- Hidden trophies
- Story progression
- Side quests
- Collectibles
- Difficulty trophies
- DLC trophies
- Platinum requirements

If the game is known, research publicly available information before generating timestamps.

Use sources such as:

- PSNProfiles
- Trophy roadmaps
- Trophy guides
- Walkthroughs
- Game Wiki pages

Cross-reference multiple sources whenever possible to ensure the progression is accurate.

Use these sources ONLY to understand the intended progression of the game.

Never copy another player's timestamps.

Generate a completely original timeline.

PARTIALLY COMPLETED TROPHY SETS

If some trophies are already unlocked in the provided JSON:

• Treat those timestamps as real.
• Use them as reference points.
• Continue the remaining progression naturally from the existing timestamps.
• Do NOT modify existing timestamps unless explicitly instructed.
• Maintain realistic spacing between existing and newly generated trophies.

UNOBTAINABLE TROPHIES

If a trophy is unobtainable as of the requested year (for example because online servers were shut down or the trophy has become impossible to earn):

• Leave it exactly as it is.
• Do NOT fabricate timestamps for unobtainable trophies.
• Do NOT modify their unlock status.
• Continue generating timestamps only for trophies that remain obtainable.

REALISM REQUIREMENTS

Simulate an actual human playthrough.

Include realistic:

• Story progression
• Exploration
• Side missions
• Collectibles
• Boss fights
• Grinding
• Deaths and retries
• Inventory management
• Menu navigation
• Loading screens
• Fast travel
• Cutscenes
• Dialogue
• AFK breaks
• Meal breaks
• Sleep between long sessions
• Optional content
• DLC progression
• Platinum cleanup

The pace should naturally speed up and slow down depending on gameplay.

Examples:

- Tutorials unlock quickly.
- Boss trophies require significant gameplay.
- Grinding trophies take hours.
- Collectibles are spread throughout the game unless a cleanup phase is more realistic.
- Platinum should almost always be the final trophy.

TIMESTAMP QUALITY

Avoid timestamps that obviously look AI generated.

DO NOT:

• End every timestamp with :00.
• End every timestamp with :30.
• Repeat the same seconds values.
• Repeat obvious patterns.
• Unlock trophies at perfectly equal intervals.
• Generate duplicate timestamps.
• Generate timestamps only a few seconds apart unless multiple trophies would realistically unlock together.

Instead:

• Randomize hours naturally.
• Randomize minutes naturally.
• Randomize seconds naturally.
• Use every second value (00–59) naturally.
• Create realistic gaps between trophies.
• Occasionally generate long breaks.
• Occasionally generate rapid unlock chains when appropriate.
• Make every timestamp feel unique.

FINAL VALIDATION

Before returning the JSON, verify:

✓ JSON is valid.
✓ Every trophy is still present.
✓ Every ID is unchanged.
✓ Every field is preserved.
✓ JSON array order is identical.
✓ Only timestamps were modified.
✓ Existing timestamps remain unchanged unless requested.
✓ Story progression is logical.
✓ Collectibles are believable.
✓ DLC progression makes sense.
✓ No duplicate timestamps exist.
✓ No impossible progression exists.
✓ Unobtainable trophies remain untouched.
✓ The final output resembles a genuine player's trophy history.

Return ONLY the completed JSON.
```

</details>

---

## 🎮 Original Features

All original features remain unchanged, including:

- Trophy editing
- Timestamp editing
- RPCS3 support
- Trophy resigning
- Smart copy
- Multi-language support

---

## ⚠️ Warning

Modifying trophy data and syncing it to PlayStation Network may violate Sony's Terms of Service and could result in account restrictions.

Always back up your original trophy files.

---

## 🙏 Credits

This project is based on **PS3TrophyIsGood** by **darkautism**.

Original repository:

https://github.com/darkautism/PS3TrophyIsGood

This repository adds JSON import/export functionality for easier integration with external tools and LLMs.

---

## ⭐ Support

If you find this project useful, consider starring the repository.
