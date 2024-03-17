<script setup lang="ts">
import TradingCard from "./components/cards/TradingCard.vue"
import CombatMapInsets from "./components/tables/CombatMapInsets.vue";
</script>

<template>
  <main :class="styles.MainContainer">
    <CombatMapInsets />
    <TradingCard />
  </main>
</template>

<style scoped module="styles" lang="scss">
.MainContainer {
  margin: auto;
  padding: 1rem;
}
</style>
