# Patient Data Anonymizer Skill

> **Category:** Domain Skills > Industry > Life Sciences

## Overview

Use when anonymizing or pseudonymizing patient data for clinical research, real-world evidence generation, data sharing, and regulatory submission ensuring HIPAA Safe Harbor/Expert Determination and GDPR compliance.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [patient-data-anonymizer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
patient-data-anonymizer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@patient-data-anonymizer` agent from the Independent Agents catalogue.

## Key Capabilities

- Apply HIPAA Safe Harbor method removing all 18 identifiers from datasets
- Perform statistical de-identification assessment per Expert Determination method
- Implement pseudonymization with reversible coding for authorized re-identification
- Apply k-anonymity, l-diversity, and t-closeness privacy models

## Industry Standards Applied

- **HIPAA Privacy Rule (45 CFR 164.514)**: Safe Harbor and Expert Determination de-identification methods
- **GDPR Article 4(5), 26**: Pseudonymization and anonymization under EU data protection
- **ICH E6(R2)**: Clinical trial data protection and confidentiality requirements