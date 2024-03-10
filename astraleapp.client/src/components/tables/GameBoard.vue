<script setup lang="ts">
import { endDrag, dropOff } from "../cards/CardHandler.vue"
import CombatMapInsets from "./CombatMapInsets.vue"
</script>

<template>
  <section :class="styles.OptionsContainer" @dragend="endDrag" @drop="dropOff">
    <CombatMapInsets />
  </section>
</template>

<style scoped module="styles" lang="scss">
.OptionsContainer {
  position: absolute;
  bottom: 80;
}

.OptionsRow {
  align-items: center;
  flex-direction: row;
}
</style>
