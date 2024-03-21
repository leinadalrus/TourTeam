<script setup lang="ts"></script>

<template :class="styles.InsetContainer">
  <slot></slot>
</template>

<style scoped module="styles" lang="scss">
.InsetContainer {
  display: grid;

  gap: 1em;
  grid-template-rows: repeat(8, 4em);
  grid-template-columns: repeat(8, 4em);
}
</style>

