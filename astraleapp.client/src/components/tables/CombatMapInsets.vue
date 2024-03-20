<script setup lang="ts">
import { ref, watch } from "vue"
import dropOff from "CardHandler.vue"
import endDrag from "CardHandler.vue"
// "computed" are read-only values

const tilemap2D = ref([0, [0]])

watch(tilemap2D, (vectors) => {
  try {
    console.table(vectors)
  } catch (error: any) {
    console.log(error)
  }
})
</script>

<template :class="styles.OptionsContainer" ondragend="endDrag" ondrop="dropOff">
  <slot></slot>
</template>

<style scoped module="styles" lang="scss">
.OptionsContainer {
  position: relative;
  display: grid;

  gap: 1em;
  grid-template-rows: repeat(8, 4em);
  grid-template-columns: repeat(8, 4em);
}
</style>

