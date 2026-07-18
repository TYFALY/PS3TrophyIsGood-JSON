<div align="center">

# PS3TrophyIsGood - JSON Edition

A small extension to **PS3TrophyIsGood** that adds JSON import and export support for AI-assisted trophy timestamp editing.

![Demo](http://4.bp.blogspot.com/-dMj1nom1pKc/USnCAcmDu6I/AAAAAAAADWg/UFiD6o3uguU/s1600/t1.png)

</div>

## ✨ What's New

This edition adds a simple JSON workflow to the original project.

- 📤 **Export to JSON**
  - Export trophy information (ID, Name, Unlock Status, Timestamp) to a JSON file.

- 📥 **Import from JSON**
  - Import edited JSON files back into the application.

- 🤖 **LLM-Friendly**
  - Makes it easy to use ChatGPT, Claude, Gemini, or other LLMs to generate realistic trophy timestamps.

---

## 📖 About

This repository is based on the original **PS3TrophyIsGood** project by **darkautism**.

The only functional addition in this version is JSON export/import support, allowing trophy data to be edited externally before importing it back into the application.

All original trophy editing functionality comes from the original project.

---

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

## 🤖 Example Prompt

> Update these trophy timestamps to simulate a realistic 13-hour play session on **2026-07-18**. Keep the unlock order logical and generate believable timestamps with natural gameplay breaks.

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
