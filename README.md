# 🦙 Lazy VPM Package Template

A simple VPM package template with **non-unity-structure** and GitHub Action workflows for managing releases: creating, updating, and testing.

## ▶ Getting Started

1. **Generate Template**  
   [![Use this template](.git_resources/button.png)](https://github.com/SweetForest/LazyVPMPackageTemplate/generate)

2. **Set Workflow Permissions**  
   After generating the repository, go to your repository's settings and enable workflows under `Settings > Actions > General`. Look at **Workflow permissions** and give **Read and write permissions.** 🔒

3. **Upload Your Files**  
   Replace the template files with your own project files. and push it on github. Make sure you still keep folder .github/workflows for automated release management. 📂
   
## 📦 Publishing a Release

The release process is managed through the `release.yml` file in the `/actions/workflows/` directory. The workflow offers three modes of operation: **Create**, **Update**, and **Test**. When triggering a workflow manually, you can choose one of these options:

- **Create**:  
  This will create a public release. 🌍 Before releasing, it checks if the version you're about to release already exists. If it does, the release process will abort to avoid duplicates. ❌

- **Update**:  
  This mode will update the existing release version by uploading all new build files, while keeping the release notes intact. 🔄

- **Test**:  
  This mode will create a **draft** release, allowing you to test the release process without making it public. 📝

Once you have set everything up, you can trigger the workflow from the **Actions** tab in your GitHub repository. Select the **release.yml** workflow, click the "Run workflow" button, and choose your desired release option (Create/Update/Test) from the dropdown. 🎉

---

## 🛠️ Updating the VPM Workflow

If you haven't created your VPM yet, you can generate it from the following template: [VRChat Community Template Package Listing](https://github.com/vrchat-community/template-package-listing).

To set up the workflow for updating the VPM:

1. **Generate Personal Access Token**:
   - Go to [GitHub Personal Access Tokens](https://github.com/settings/tokens).
   - Click on **"Generate new token"**.
   - Select the necessary scopes (`workflow`).
   - Copy the token after generating it.

2. **Add the Token as a Secret**:
   - In your repository, go to `Settings > Secrets and variables > Actions`.
   - Click **"New repository secret"**.
   - Name it (e.g., `REPO_ACCESS_TOKEN`) and paste the token.
   - Click **"Add secret"**.

3. **Configure Your Workflow**:
   - Update your workflow YAML file located at `.github/workflows/build-listing.yml` to reference the secret and set up the necessary steps for triggering the workflow.
---

### 📂 `.git_resources`

The `.git_resources` folder contains files like images for documentation purposes on GitHub (e.g., images used in the README file). These files will **not be included in the build process**.

Similarly, the `README.md` file displayed on the main repository page serves as documentation only and will also **not be included in the build process**.

## 💖 Support Me

Visit my booth for supporting me [SweetForest's Booth](https://sweetforest.booth.pm)

---
