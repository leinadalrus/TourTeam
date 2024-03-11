<script setup lang="ts">
</script>

<template>
  <article :class="styles.GridmapContainer"></article>
</template>

<style scoped module="styles" lang="scss">
.GridmapContainer {
  display: grid;
  gap: 1em;
  grid-template-rows: repeat(8, 4em);
  grid-template-columns: repeat(8, 4em);
}
</style>
