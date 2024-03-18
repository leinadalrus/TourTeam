<script setup lang="ts">
import { ref, watch } from "vue"

const vesselURL = ref("")

watch(vesselURL, () => {})
</script>

<template>
  <img :src="vesselURL" alt="Ship vessel image" aria-label="Ship vessel image." :class="styles.ImageContainer" />
</template>

<style scoped module="styles" lang="scss">
.ImageContainer {
  margin: auto;
}
</style>
