<script setup lang="ts">
import CombatMapInsets from "./components/tables/CombatMapInsets.vue"
import NavMenu from "./components/navmenu/NavMenu.vue"
import TradingCard from "./components/cards/TradingCard.vue"
</script>

<template>
  <header>
    <NavMenu />
  </header>
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
