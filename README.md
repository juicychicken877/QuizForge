# Quiz Forge - Quiz Creation and Solving App

## 📌 About
Quiz Forge is a Windows Forms application built with .NET Core in C# that allows users to create, edit, import, export, and delete quizzes. The app provides an intuitive interface for both quiz makers and quiz takers, making learning and testing knowledge easy and efficient.

## 🎯 Features
- ✅ Create and edit quizzes with multiple questions.
- 📥 Import quizzes from external files.
- 📤 Export quizzes for sharing.
- 🗑️ Delete quizzes when no longer needed.
- 🎮 Solve quizzes and get instant feedback.
- 🤖 **NEW: AI Prompt Generator:** Generate AI prompts based on user input to create quiz JSON data.

## 🚀 Getting Started
### Prerequisites
- .NET Core SDK (latest version)
- Windows OS (for Windows Forms support)

### Installation
1. Clone the repository:
    ```sh
    git clone [https://github.com/juicychicken877/QuizForge.git](https://github.com/juicychicken877/QuizForge.git)
    ```
2. Open the project in Visual Studio.
3. Build and run the application.

## 🤖 AI Prompt Generator Feature

### How to Use
1.  **Input Quiz Parameters:** In the AI Prompt Generator section of the application, enter your desired quiz parameters. This might include:
    * The number of quizzes.
    * The number of questions per quiz.
    * The number of answers per question.
    * Specific quiz topics or categories.
    * Any questions you want to avoid.
2.  **Copy Prompt:** The application will generate a text prompt that you can copy to your clipboard.
3.  **Use with AI:** Paste the prompt into an AI model (like a large language model) capable of generating JSON data.
4.  **Generate JSON:** The AI will produce a JSON text or file containing a list of quizzes based on your specifications.
5.  **Import to Quiz Forge:** Import the generated JSON file or paste the JSON text into Quiz Forge to use your new quizzes.

### Example Prompt
Generate a JSON file containing a list of 3 quizzes. Each quiz should have 4 questions. Each question should have 4 answers. Avoid quizzes about "History".