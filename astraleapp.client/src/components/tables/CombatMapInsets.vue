<script setup lang="ts">
import SectGridmap from "./SectGridmap.vue"
// "computed" are read-only values
</script>

<template>
  <section :class="styles.OptionsContainer" @dragend="endDrag" @drop="dropOff">
    <SectGridmap />
  </section>
</template>

<style scoped module="styles" lang="scss">
.OptionsContainer {
  position: absolute;
  bottom: 4rem;
}

.OptionsRow {
  align-items: center;
  flex-direction: row;
}
</style>

