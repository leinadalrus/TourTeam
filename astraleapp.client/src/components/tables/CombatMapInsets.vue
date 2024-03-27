<script setup lang="ts">
import dropOff from "../cards/CardHandler.vue";
</script>

<template class="styles.InsetContainer"
    v-for="card in areas"
    :key="card.id"
    @drop="dropOff($event, card.id)"
    @dragover.prevent
    @dragenter.prevent
>
  <slot></slot>
</template>

<style scoped module="styles" lang="scss">
.InsetContainer {
  max-width: 3rem;
  max-height: 8rem;

  min-width: 3rem;
  min-height: 8rem;

  margin: 1rem;
  padding: 1rem;
  background-color: #0f1014;
}
</style>

