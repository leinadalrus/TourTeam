<script setup lang="ts"></script>

<template>
  <section :class="styles.CharacterEditorForm">
    <form action="" method="post">
      <label for="">Input Character Name:</label>
      <input type="text">

      <label for="">Class Type(s):</label>
      <input type="checkbox" name="" id="">

      <label for="">Avatar/Profile Picture:</label>
      <input type="image" src="" alt="">

      <div>
        <input type="submit" value="">
      </div>
    </form>
  </section>
</template>

<style scoped module="styles" lang="scss">
.CharacterEditorForm {
  margin: auto;
  padding: auto;
}
</style>