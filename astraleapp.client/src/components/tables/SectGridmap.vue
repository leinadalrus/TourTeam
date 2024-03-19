<script setup lang="ts">
import { ref, watch } from "vue"

const tilemap2D = ref([0, [0]])

watch(tilemap2D, (vectors) => {
  try {
    console.table(vectors)
  } catch (error: any) {
    console.log(error)
  }
})
</script>

<template ref="tilemap2D">
  <article :class="styles.GridmapContainer">
    <!-- Trading Card SFC as a Slot, here: ...-->
   <slot></slot>
  </article>
</template>

<style scoped module="styles" lang="scss">
.GridmapContainer {
  display: grid;
  gap: 1em;
  grid-template-rows: repeat(8, 4em);
  grid-template-columns: repeat(8, 4em);
}
</style>
