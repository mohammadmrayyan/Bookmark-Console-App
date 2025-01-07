# Git & GitHub

## Git

### Global Configuration

```bash
git config --global user.name "Your Name"
git config --global user.email "
git config --global init.defaultBranch main
```

## Git Commands

### Initialize Git Repository

```bash
git init
```

### Add Files to Staging Area

```bash
git add .
```

### Commit Changes

```bash
git commit -m "Commit Message"
```

### Check Status

```bash
git status
```

### Check Commit History

```bash
git log
```

### Check Commit History with Graph

```bash
git log --graph --oneline --all
```

### Add Remote Repository

```bash
git remote add origin git@github.com:USERNAME/REPOSITORY.git
```

### Push Changes to Remote Repository

```bash
git push -u origin main
```

> -u flag sets the upstream branch to main (default branch)

## GitHub

## SSH Key

### Generate SSH Key

```bash
ssh-keygen -t rsa -b 4096 -C "your_email@example.com"
```

### Commit Signing using SSH

```bash
git config --global gpg.format ssh
git config --global user.signingkey /PATH/TO/.SSH/KEY.PUB
```

### Commit with Signed Key

```bash
git commit -S -m "Commit Message"
```
