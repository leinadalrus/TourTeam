<script setup lang="ts">
import SectGridmap from "./SectGridmap.vue"
import dropOff from "CardHandler.vue"
import endDrag from "CardHandler.vue"
// "computed" are read-only values
</script>

<template>
  <section :class="styles.OptionsContainer" ondragend="endDrag" ondrop="dropOff">
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

