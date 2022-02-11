# A Programming Language to teach my daughter with

## Introduction

My daughter wanted to learn to program and also wanted to know how programming
languages work. So I figured, let's kill two birds with one stone.

So, we started to write a programming language as our project. At the time that I first
commit this to GitHub and I'm writing this document, we've spent about two hours together
working on understanding how to code. I struggled a little to make operator prescedence work
while also teaching her, so I spent another hour going back and cleaning up the parser a little.

This morning before checking in, I decided it would make sense to get unit testing working before
we went any further. Since I'm intentionally hand coding the parser and attempting to use simplified
programming practices to avoid unwanted obfuscation during teaching, unit tests are far more important
than they'd have been otherwise. After writing only two tests (and implementing a little AST reduction while
doing so, I've already caught quite a few parser errors.

## The goal

To show off for my daughter and make her realize pappa's not just pretending to be good at computer stuff.

As a secondary goal, we have none. But I'm thinking of a few ideas.

Once I've gotten the foundation laid out a little more, I think the next major step is to moving a direction. 
I don't know how long I'll continue with this project, but I figure that while I do, I could try to make an attempt 
to check things in an possibly be good about tagging when there's something new running.

## What will it do?

As she has expressed interest in "old school" and as a child seemed fascinated with Bill Gates, I figured
what would be more interesting than making a programming language designed to work on an Altair 8800?

So, I'll make use of Blazor and an open source Altair 8800 simulator to let our language produce code that will
run on that in a web browser.

## Session 1

So, at the first checkin, what does the language do?

Well, it's a simple expression parser. And I mean really limited, but it's a start. At this point, it appears to
support operator precedence as well as parenthesis and all that fun stuff. I've already decided that there will
need to be some restructuring to support variables and executing functions. But it should be a pretty trivial change.

There are a total of two unit tests so far and it will grow from here.
