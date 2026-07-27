# 📚 Student Exam Qualification Calculator

> A simple console application that calculates a student's final exam mark from weighted component scores and determines whether they qualify to write the final exam.

---

## 📋 Table of Contents
- [Overview](#overview)
- [Weighting Scheme](#weighting-scheme)
- [Prerequisites](#prerequisites)
- [Quick Start](#quick-start)
- [Usage Guide](#usage-guide)
- [Sample Input/Output](#sample-inputoutput)
- [Error Handling](#error-handling)
- [Troubleshooting](#troubleshooting)
- [Technical Details](#technical-details)

---

## 📊 Overview

This application provides a quick and reliable way to calculate student exam qualifications using a weighted scoring system. It's containerized with Docker for easy deployment across any platform.

**Qualification Criteria:** A student qualifies if their final mark is **50% or higher**.

---

## ⚖️ Weighting Scheme

| **Component** | **Weight** |
|---------------|------------|
| Test 1 | 30% |
| Test 2 | 50% |
| Assignment 1 | 10% |
| Project | 10% |

---

## 🛠️ Prerequisites

Before running this application, ensure you have **Docker** installed on your system:

- **Windows/Mac:** [Docker Desktop](https://www.docker.com/products/docker-desktop/)
- **Linux:** Docker Engine

### Verify Docker Installation

```bash
docker --version
```

**Expected Output:**
```
Docker version 27.x.x, build xxxxxxx
```

> 💡 **No other software is required** — Docker packages everything the app needs to run.

---

## 🚀 Quick Start

### 1️⃣ Pull the Docker Image

```bash
docker pull reneumbra/student-exam-app:latest
```

### 2️⃣ Run the Application

Since this is an **interactive console app** (requires user input), use the `-it` flag:

```bash
docker run -it --rm reneumbra/student-exam-app:latest
```

#### Flag Breakdown

| **Flag** | **Purpose** |
|----------|-------------|
| `-i` | Keeps STDIN open for keyboard input |
| `-t` | Allocates a terminal for proper display |
| `--rm` | Automatically removes the container after exit |

---

## 💻 Usage Guide

1. **Run the container** using the command above
2. **Enter marks** when prompted (0–100)
3. **Review results** — final mark and qualification status
4. **Press any key** to exit

---

## 📝 Sample Input/Output

### ✅ Valid Input Example

```
--- Student Exam Qualification Calculator ---

Enter Test 1 mark (30%): 65
Enter Test 2 mark (50%): 58
Enter Assignment 1 mark (10%): 80
Enter Project mark (10%): 90

Final Mark: 65.50%
Result: Student QUALIFIES to write the exam.

Press any key to exit...
```

### ❌ Invalid Input Handling

The app validates all inputs and will reject:

- Non-numeric values
- Values outside the 0–100 range

```
Enter Test 1 mark (30%): abc
Invalid mark. Please enter a value between 0 and 100.

Enter Test 1 mark (30%): 150
Invalid mark. Please enter a value between 0 and 100.

Enter Test 1 mark (30%): 72
```

---

## 🔧 Troubleshooting

Common Docker errors and solutions:

| **Error** | **Solution** |
|-----------|--------------|
| `docker: command not found` | Docker isn't installed or not in PATH. Reinstall Docker Desktop and restart your terminal. |
| `Cannot connect to the Docker daemon` | Docker Desktop isn't running. Open Docker Desktop and wait for it to fully start. |
| `Unable to find image '...' locally` | Image name/tag is incorrect. Double-check the exact name with the repository. |
| App hangs with no prompt | Running without `-it`. Re-run with: `docker run -it --rm` |
| `permission denied` (Linux) | User not in `docker` group. Run: `sudo usermod -aG docker $USER` then log out and back in. |
| `exec format error` | CPU architecture mismatch. Rebuild with: `docker buildx build --platform linux/amd64 -t .` |
| Container exits immediately | App crashed. Check logs: `docker logs <container-id>` |

---

## 📐 Technical Details

### Architecture
- **Language:** Python 3.x
- **Containerization:** Docker
- **Base Image:** python:3.9-alpine

### Build & Publish

For developers looking to build the image:

```bash
# Build the image
docker build -t reneumbra/student-exam-app:latest .

# Push to Docker Hub
docker push reneumbra/student-exam-app:latest
```

---

## 📄 License

This project is open-source and available under the MIT License.

---

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

---

## 📞 Support

For issues or questions, please:
1. Check the [Troubleshooting](#troubleshooting) section first
2. Open an issue in the repository
3. Contact the development team

---

**Happy Calculating!** 🎓📊