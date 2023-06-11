<script setup>
import WelcomeItem from './WelcomeItem.vue'
import IconGithub from './icons/IconGithub.vue';
import IconLinkedin from './icons/IconLinkedin.vue';
import IconMail from './icons/IconMail.vue';
</script>

<template>
  <WelcomeItem>
    <template #icon><IconLinkedin /></template>
    <template #heading>LinkedIn</template>
    
    <a href="https://www.linkedin.com/in/merkithuseyin/" target="_blank" rel="noopener">LinkedIn</a>
  </WelcomeItem>

  <WelcomeItem>
    <template #icon><IconGithub /></template>
    <template #heading>GitHub</template>
    
    <a href="https://github.com/merkithuseyin" target="_blank" rel="noopener">GitHub</a>
  </WelcomeItem>

  <WelcomeItem>
    <template #icon><IconMail /></template>
    <template #heading>Mail</template>
    
    <a href="mailto:merkithuseyin@gmail.com" target="_blank" rel="noopener">merkithuseyin@gmail.com</a>
  </WelcomeItem>
</template>