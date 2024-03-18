<script setup lang="ts">
import { ref, watch } from "vue"

const avatarURL = ref("")

watch(avatarURL, () => {})
</script>

<template>
  <img :src="avatarURL" alt="A Custom Profile Image" aria-label="Custom Profile Image" />
</template>

<style scoped module="styles" lang="scss"></style>