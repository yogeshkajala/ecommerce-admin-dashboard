# React Performance Optimizer Skill

> **Category:** Tech Skills > Frontend > React

## Overview

Profiles and optimizes React application performance through rendering analysis, memoization, and bundle size optimization

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [react-performance-optimizer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
react-performance-optimizer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@react-performance-optimizer` agent from the Independent Agents catalogue.

## Key Capabilities

- Profile rendering with React DevTools Profiler
- Implement React.memo with custom comparison functions
- Optimize with useMemo, useCallback, and useTransition
- Analyze and reduce bundle size with source map explorer

## Technology Standards Applied

- **React Profiler**: Official profiling tool for rendering analysis
- **Core Web Vitals**: LCP, INP, CLS targets for React applications
- **Bundle Analysis**: Source map explorer for bundle optimization