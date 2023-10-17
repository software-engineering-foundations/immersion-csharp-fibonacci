# Git Training Exercise - Conflict Resolution

This is a training exercise to practice indentifying and resolving conflicts in Git. It is a C# project.

Please note that lots of the code in this repo is deliberately overly verbose and inefficient. This is to generate some more intersting conflicts - I would not suggest using any of the code here if your objective is just to calculate Fibonacci numbers! 

## Setup

1. Clone the repository.
2. Run the tests with `dotnet test`

## Task

This repository has several branches. Your task is to combine them into one that will contain the features of all of them. Beware - conflicts lie ahead (that is, after all, the main point of the exercise)!

This exercise will be most effective if you merge the branches in the order described below:

1. handle-negatives
2. handle-null
3. compute-array
4. optional-recursion
5. negative-recursion
6. variable-names

This is not the easiest order in which to merge the branches. However, this approach leads to the most interesting conflicts and is a good reflection of reality where feature branches aren't necessarily always merged in the most convenient order.

## Tests and Correctness

All branches include tests. Conveniently, whoever wrote the tests (:eyes:) made sure that they are all in different files, so there should be no conflicts there.

Tests are always supposed to be right and you should not need to edit them at any point to make them pass.

## Approach

The goal state of this exercise is a `master` branch that contains all of the features that are currently split onto separate feature branches. **You should not have to write or modify any code outside of the merge conflict resolution process.**

To get familiar with git and remote git repositories, there are a couple of approaches you can take to resolving these conflicts. I'd recommend working through them in order - the first one is the most refective of the standard development process on a multi-developer project, but the others are great practice.

Before starting to resolve the conflicts on each branch, it's a good idea to take a look through the changes and make sure you understand how the new code and test(s) on the branch work.

1. Without using Azure DevOps, get all of the features on to the `master` branch only using `git merge` commands.
2. Without using Azure DevOps, get all of the features onto a single branch only using `git rebase` commands (this branch doesn't have to be `master`).

After each run-through, you will want to revert your repository back to its starting state. You might want to explore ways of doing this (without re-forking the original repo), for example:

- adding remote to the original repo and resetting `--hard`
- reflog (git reference logs)
