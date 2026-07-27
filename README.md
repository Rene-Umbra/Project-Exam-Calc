# 📚 Student Exam Qualification Calculator

A simple C# console application that calculates a student's weighted final mark and determines whether they qualify to write the final exam.

---

## 📋 Table of Contents
- [Overview](#overview)
- [Weighting Scheme](#weighting-scheme)
- [Prerequisites](#prerequisites)
- [Run with Docker](#run-with-docker)
- [Run Locally](#run-locally)
- [Example Input/Output](#example-inputoutput)
- [Build and Publish](#build-and-publish)

---

## 📊 Overview

This project uses a weighted scoring system to calculate a student's final mark from four assessment components:

- Test 1: 30%
- Test 2: 50%
- Assignment 1: 10%
- Project: 10%

A student qualifies if their final mark is 50% or higher.

---

## ⚖️ Weighting Scheme

| Component | Weight |
|-----------|--------|
| Test 1 | 30% |
| Test 2 | 50% |
| Assignment 1 | 10% |
| Project | 10% |

---

## 🛠️ Prerequisites

To run this app, you need either:

- Docker, for the containerized version
- .NET 10 SDK, for running it locally

Verify your installation with:

```bash
docker --version
```

or

```bash
dotnet --version
```

---

## 🚢 Run with Docker

Pull and run the published image from Docker Hub:

```bash
docker pull reneumbra/student-exam-app:latest
docker run -it --rm reneumbra/student-exam-app:latest
```

The `-it` flags keep the console interactive so you can enter marks.

---

## 💻 Run Locally

From the project folder, run:

```bash
dotnet restore
dotnet run
```

---

## 📝 Example Input/Output

```text
--- Student Exam Qualification Calculator ---

Enter Test 1 mark (30%): 65
Enter Test 2 mark (50%): 58
Enter Assignment 1 mark (10%): 80
Enter Project mark (10%): 90

Final Mark: 65.50%
Result: Student QUALIFIES to write the exam.

Press any key to exit...
```

Invalid inputs are rejected if they are not numeric or fall outside the 0–100 range.

---

## 🔧 Build and Publish

Build the Docker image locally:

```bash
docker build -t reneumbra/student-exam-app:latest .
```

Push it to Docker Hub:

```bash
docker push reneumbra/student-exam-app:latest
```

---

## 📄 License

This project is open-source and available under the MIT License.

---

## 🤝 Contributing

Contributions are welcome. Feel free to open a pull request or suggest improvements.
