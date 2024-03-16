<script setup lang="ts">
import { ref, watch } from "vue"

const avatarURL = ref("")

watch(avatarURL, () => {})
</script>

<template>
  <article>
    <img :src="avatarURL" alt="A Custom Profile Image" aria-label="Custom Profile Image" />
  </article>
</template>

<style scoped module="styles" lang="scss"></style>