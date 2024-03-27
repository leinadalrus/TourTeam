<script setup lang="ts">
import CombatMapInsets from "./components/tables/CombatMapInsets.vue"
import NavMenu from "./components/navmenu/NavMenu.vue"
import TradingCard from "./components/cards/TradingCard.vue"
</script>

<template>
  <header>
    <NavMenu />
  </header>
  <main>
    <CombatMapInsets>
      <TradingCard />
    </CombatMapInsets>
  </main>
</template>

<style lang="scss">
$text: oklab(94.12% 0.009 -0.02);
$background: oklab(7.30% 0.003 -0.02);
$primary: oklab(69.79% 0.038 -0.12);
$secondary: oklab(12.16% 0.001 -0.08);
$accent: oklab(41.72% 0.102 0.04);
</style>
